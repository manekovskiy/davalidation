using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Globalization;
using System.Linq;
using System.Web;
using System.Web.Compilation;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace DAValidation
{
	public class DataAnnotationsValidator : BaseValidator
	{
#if NET45
		public const string DAValidationScriptFileName = "DAValidation.DAValidation.NET45.js";
#else
		public const string DAValidationScriptFileName = "DAValidation.DAValidation.NET40.js";
#endif

		private const string MetadataSourceViewStateKey = "DataAnnotationsValidator_MetadataSourceID";

		[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1709:IdentifiersShouldBeCasedCorrectly", MessageId = "ID", Justification = "This should be named with ID at the end, because it is keeping consistency in naming.")]
		[Category("Behavior")]
		[Themeable(false)]
		[DefaultValue("")]
		[IDReferenceProperty(typeof(MetadataSource))]
		public string MetadataSourceID
		{
			get
			{
				return Convert.ToString(ViewState[MetadataSourceViewStateKey], CultureInfo.InvariantCulture);
			}
			set
			{
				ViewState[MetadataSourceViewStateKey ] = value;
			}
		}

		private MetadataSource MetadataSource 
		{
			get; set;
		}

		[Category("Behavior")]
		[Themeable(false)]
		[DefaultValue("")]
		public string ObjectProperty { get; set; }

		private IEnumerable<ValidationAttribute> ValidationAttributes { get; set; }
		private string DisplayName { get; set; }

		protected override void OnLoad(EventArgs e)
		{
			base.OnLoad(e);

			if (!ControlPropertiesValid())
				return;

			MetadataSource = GetMetadataSource();

			ValidationAttributes = MetadataSource.GetValidationAttributes(ObjectProperty);
			DisplayName = MetadataSource.GetDisplayName(ObjectProperty);
		}

		[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Reliability", "CA2000:Dispose objects before losing scope", 
			Justification = "MetadataSource object should not be disposed as it is used by the class instance to set values for ValidationAttributes and DisplayName properties")]
		private MetadataSource GetMetadataSource()
		{
			if (!string.IsNullOrEmpty(MetadataSourceID))
			{
				return this.FindChildControl<MetadataSource>(MetadataSourceID);
			}
#if NET45
			// Since user didn't set MetadataSourceID we'll try to resolve model type automatically, i.e. go up through parent controls 
			// to the first DataBoundControl which has non-empty ItemType property or Page.
			// If we reached Page or ItemType properties of all found DataBoundControls are empty then we'll throw an exception.
			var currentParent = Parent;
			while (!(currentParent is Page))
			{
				var dataBoundControl = currentParent as DataBoundControl;
				if (dataBoundControl != null)
				{
					if (!string.IsNullOrWhiteSpace(dataBoundControl.ItemType))
					{
						return new MetadataSource
						{
							ObjectType = BuildManager.GetType(dataBoundControl.ItemType, true /* throwOnError */, true /* ignoreCase */)
						};
					}
				}

				currentParent = currentParent.Parent;
			}
#endif
			// We did't found DataBoundControl with non-empty ItemType property
			throw new HttpException("MetadataSourceID property cannot be blank");
		}

		protected override bool EvaluateIsValid()
		{
			object value = GetControlValidationValue(ControlToValidate);
			foreach (ValidationAttribute validationAttribute in ValidationAttributes)
			{
				if (validationAttribute.IsValid(value)) continue;
			
				ErrorMessage = validationAttribute.FormatErrorMessage(DisplayName);
				return false;
			}

			return true;
		}

		protected override bool ControlPropertiesValid()
		{
#if !NET45
			if (string.IsNullOrEmpty(MetadataSourceID))
				throw new HttpException("MetadataSourceID property cannot be blank");
#endif
			return base.ControlPropertiesValid();
		}

		protected override void AddAttributesToRender(HtmlTextWriter writer)
		{
			if (RenderUplevel)
			{
				this.RegisterExpandoAttribute(writer, "evaluationfunction", "DAValidation.DataAnnotationsValidatorIsValid");

				var validationRules = ValidationAttributes.SelectMany(attribute => ClientValidationRulesProvider.GetClientValidationRules(attribute, DisplayName));
				var errorMessages = ValidationAttributes.Select(attribute => attribute.FormatErrorMessage(DisplayName));

				var validatorFunctions = new List<string>();
				foreach (var rule in validationRules)
				{
					validatorFunctions.Add(rule.EvaluationFunction);
					foreach (var ruleParameter in rule.Parameters)
					{
						this.RegisterExpandoAttribute(writer, ruleParameter.Key, Convert.ToString(ruleParameter.Value, CultureInfo.InvariantCulture));
					}
				}

				this.RegisterExpandoAttribute(writer, "validatorfunctions", string.Join(";;", validatorFunctions));
				this.RegisterExpandoAttribute(writer, "errormessages", string.Join(";;", errorMessages));
				this.RegisterExpandoAttribute(writer, "supresserrormessagetext", Text.Trim().Length > 0 ? "true" : "false");
			}

			base.AddAttributesToRender(writer);
		}

		protected override void OnPreRender(EventArgs e)
		{
			base.OnPreRender(e);

			if (RenderUplevel)
			{
				var scriptManager = ScriptManager.GetCurrent(Page);
				if (scriptManager != null && scriptManager.IsInAsyncPostBack)
					ScriptManager.RegisterClientScriptResource(this, GetType(), DAValidationScriptFileName);
				else
					Page.ClientScript.RegisterClientScriptResource(GetType(), DAValidationScriptFileName);
			}
		}
	}
}