using CollectionViewSample.Models;
using System.Collections.ObjectModel;

namespace CollectionViewSample.ViewModels;

public class MainViewModel
{
    public ObservableCollection<PersonModel> People { get; set; } = new ObservableCollection<PersonModel>();

    public void Init()
    {
        var peeps = new List<PersonModel>()
        {
            new PersonModel
            {
                Name = "Bob",
                Title = "CEO"
            },
            new PersonModel
            {
                Name = "Mary",
                Title = "CFO"
            },
            new PersonModel
            {
                Name = "Mildred",
                Title = "CIO"
            },
            new PersonModel
            {
                Name = "Youssouf",
                Title = "Facilities Manager"
            },
            new PersonModel
            {
                Name = "Andew",
                Title = "Admin assistant"
            },
            new PersonModel
            {
                Name = "Felicia",
                Title = "Stock controller"
            },
            new PersonModel
            {
                Name = "Pat",
                Title = "Security"
            },
            new PersonModel
            {
                Name = "Ben",
                Title = "CEO1"
            },
            new PersonModel
            {
                Name = "Mary1",
                Title = "CFO1"
            },
            new PersonModel
            {
                Name = "Mildred1",
                Title = "CIO1"
            },
            new PersonModel
            {
                Name = "Youssouf1",
                Title = "Facilities Manager1"
            },
            new PersonModel
            {
                Name = "Andew1",
                Title = "Admin assistant1"
            },
            new PersonModel
            {
                Name = "Felicia1",
                Title = "Stock controller1"
            },
            new PersonModel
            {
                Name = "Pat1",
                Title = "Security1"
            },
            new PersonModel
            {
                Name = "Bob2",
                Title = "CEO2"
            },
            new PersonModel
            {
                Name = "Mary2",
                Title = "CFO2"
            },
            new PersonModel
            {
                Name = "Mildred2",
                Title = "CIO2"
            },
            new PersonModel
            {
                Name = "Youssouf2",
                Title = "Facilities Manager2"
            },
            new PersonModel
            {
                Name = "Andew2",
                Title = "Admin assistant2"
            },
            new PersonModel
            {
                Name = "Felicia2",
                Title = "Stock controller2"
            },
            new PersonModel
            {
                Name = "Pat2",
                Title = "Security2"
            }
        };

        peeps.ForEach((p) => People.Add(p));
    }
}
