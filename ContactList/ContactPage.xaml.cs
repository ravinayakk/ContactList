namespace ContactList;

public partial class ContactPage : ContentPage
{
    public List<ContactGroup> Contacts = new List<ContactGroup>();

    public ContactPage()
	{
		InitializeComponent();

        Contacts.Add(new ContactGroup("Freshman", new List<Contact> {
        new Contact(){ Name="Emma Johnson", ImageName = "one.png", Email="emma.johnson@college.edu", PhoneNumber="555-123-4567", Description="Excited psychology major who loves coffee and late-night study sessions." },
        new Contact(){ Name="Liam Martinez",ImageName = "two.png", Email="liam.martinez@college.edu", PhoneNumber="555-987-6543", Description="Computer science enthusiast always debugging his code at the campus library." },
        new Contact(){ Name="Sophia Lee", ImageName = "three.png", Email="sophia.lee@college.edu", PhoneNumber="555-234-5678", Description="Aspiring journalist who runs the freshman blog and never misses a campus event." },
        new Contact(){ Name="Noah Patel", ImageName = "four.png", Email="noah.patel@college.edu", PhoneNumber="555-345-6789", Description="Engineering major who spends his free time playing intramural soccer and gaming." },
        new Contact(){ Name="Olivia Carter", ImageName = "one.png", Email="olivia.carter@college.edu", PhoneNumber="555-456-7890", Description="Passionate about environmental science and always organizing campus clean-ups." }
        }));

        Contacts.Add(new ContactGroup("Juniors", new List<Contact> {
        new Contact(){ Name="Ethan Reynolds", ImageName = "one.png",  Email="ethan.reynolds@college.edu", PhoneNumber="555-567-8901", Description="Business major juggling internships, networking events, and case competitions." },
        new Contact(){ Name="Ava Kim", ImageName = "two.png", Email="ava.kim@college.edu", PhoneNumber="555-678-9012", Description="Pre-med student who spends most of her time in the lab or volunteering at the campus clinic." },
        new Contact(){ Name="Jackson Rivera", ImageName = "three.png", Email="jackson.rivera@college.edu", PhoneNumber="555-789-0123", Description="Film student passionate about cinematography, always working on a new project." },
        new Contact(){ Name="Mia Thompson", ImageName = "four.png", Email="mia.thompson@college.edu", PhoneNumber="555-890-1234", Description="Marketing major and student ambassador who loves planning campus events." },
        new Contact(){ Name="Caleb Nguyen", ImageName = "two.png", Email="caleb.nguyen@college.edu", PhoneNumber="555-901-2345", Description="Mechanical engineering student, spends weekends building robots and hiking."}
        }));


        Contacts.Add(new ContactGroup("Senior", new List<Contact>{
       new Contact(){ Name="Benjamin Walker", ImageName = "one.png",Email="benjamin.walker@college.edu", PhoneNumber="555-012-3456", Description="Finance major preparing for graduation and applying to top consulting firms." },
       new Contact(){ Name="Isabella Hernandez", ImageName = "two.png", Email="isabella.hernandez@college.edu", PhoneNumber="555-123-4567", Description="Education major passionate about teaching and mentoring underclassmen." },
       new Contact(){ Name="Lucas Adams", ImageName = "three.png", Email="lucas.adams@college.edu", PhoneNumber="555-234-5678", Description="Computer engineering student finalizing his capstone project on AI development." },
       new Contact(){ Name="Emily Roberts", ImageName = "four.png", Email="emily.roberts@college.edu", PhoneNumber="555-345-6789", Description="Political science major interning at the state capitol and leading student government." },
       new Contact(){ Name="Daniel Scott", ImageName = "three.png", Email="daniel.scott@college.edu", PhoneNumber="555-456-7890", Description="Biology major finishing research on genetics before heading to med school." }
        }));
        LvContact.ItemsSource = Contacts;
    }

    private void LvContact_SelectionChanged(object sender, SelectionChangedEventArgs e)
    {
        var selectedItem = e.CurrentSelection.FirstOrDefault() as Contact;
        if (selectedItem == null) return;
        Navigation.PushAsync(new ContactDetailPage(selectedItem));
        ((CollectionView)sender).SelectedItem = null;
    }
}