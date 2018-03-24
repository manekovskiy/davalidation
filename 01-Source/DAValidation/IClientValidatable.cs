using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;

namespace DAValidation
{
	[SuppressMessage("Microsoft.Naming", "CA1704:IdentifiersShouldBeSpelledCorrectly", MessageId = "Validatable",
		Justification = "If ASP.NET MVC team can name their interface 'IValidatableObject' (http://msdn.microsoft.com/en-us/library/system.componentmodel.dataannotations.ivalidatableobject.aspx), why I cannot do the same?")]
	public interface IClientValidatable
	{
		[SuppressMessage("Microsoft.Design", "CA1024:UsePropertiesWhereAppropriate", Justification = "This method performs specific tasks, i.e. it is not just a plain and simple getter")]
		IEnumerable<ClientValidationRule> GetClientValidationRules();
	}
}