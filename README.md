# DAValidation
Data Annotations Validator control for ASP.NET Web Forms.

> Migrated "as-is" from the [DAValidation](https://archive.codeplex.com/?p=davalidation) project on Codeplex.

---

DAValidation makes it easier to develop and maintain ASP.NET Web Forms input validation with Data Annotations attributes. All validation logic unified in one control per field.
DAValidation borrowed the idea from the ASP.NET MVC input validation model but uses original Web Forms javascript validation library.

---

Do you like how input validation is handled in ASP.NET MVC? Or maybe you think that **code-only approach** is the most natural one for the developers? If yes, then **DAValidation is for you**! With DAValidation you can use **Data Annotations** validation attributes and have a **client-side validation**.

DAValidation fully supports **new validation attributes** (MinLength, MaxLength, Phone, CreditCard, Email, Url, FileExtensions) **and unobtrusive validation** that were introduced in **.NET 4.5**!

DAValidation is fully **compatible with standard ASP.NET Web Forms** validation (standard validation controls, ValidationSummary control, validation groups and client side validation library) and Ajax Control Toolkit Extenders.

DAValidation is available through [NuGet](https://nuget.org/packages/DAValidation).

### `PM> Install-Package DAValidation`

If you are interested what considerations were made during implementation and how control works internally refer to the article on my site.

To setup and use DAValidation you need only 3 steps:

1. Create a class or structure that is representing web form model and add some validation attributes to it
```cs
public class AccountInformation
{
    [Display(Name = "Username")]
    [Required(ErrorMessageResourceName = "AccountInformation_Username_Required", 
              ErrorMessageResourceType = typeof(Resources.AccountInformation))]
    [StringLength(10)]
    public string Username { get; set; }
}
```
2. Place MetadataSource control on the page and wire it to the class from step 1
```aspx
<dav:MetadataSource runat="server" ID="msAccountInformation" ObjectType="<%$ Code: typeof(AccountInformation) %>" />
```
3. Place DataAnnotationValidator control and connect it to MetadataSource to validate input
```aspx
<asp:TextBox ID="tbUsername" ValidationGroup="AccountInformation" runat="server" />
<dav:DataAnnotationsValidator ID="davUsername" runat="server" 
  ValidationGroup="AccountInformation"
  MetadataSourceID="msAccountInformation"
  ControlToValidate="tbUsername"
  ObjectProperty="Username" />
```

And thats it! Now you have fully functional both client and server input validation.
