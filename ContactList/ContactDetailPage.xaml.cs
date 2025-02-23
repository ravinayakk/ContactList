namespace ContactList;

public partial class ContactDetailPage : ContentPage
{
	public ContactDetailPage(Contact item)
	{
		InitializeComponent();
        ContactImage.Source = item.ImageName;
        LblContactName.Text = item.Name;
        LblContactDesc.Text = item.Description;
        LblContactEmail.Text = item.Email;
        LblContactPhoNum.Text = item.PhoneNumber;
    }
}