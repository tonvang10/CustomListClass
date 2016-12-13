using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomListClass
{
    class People
    {
        public object[] information;
        public string firstName;
        public string lastName;
        public string typeOfPet;
        public string favoriteColor;
        public int numberOfChildren;
        public int numberOfFamilyMembers;
        public int numberOfPets;
        public int age;
        public int favoriteNumber;
        public int birthday;

        public People()
        {
            information = new object[10];
        }
        public string AddFirstName()
        {
            firstName = "Ton";
            information[0] = firstName;                                         
            return firstName;           
        } 
        public string AddLastName()
        {
            lastName = "Vang";
            information[1] = lastName;
            return lastName;
        } 
        public string AddTypeOfPet()
        {
            typeOfPet = "Dog";
            information[2] = typeOfPet;
            return typeOfPet;
        }
        public string AddFavoriteColor()
        {
            favoriteColor = "Green";
            information[3] = favoriteColor;
            return favoriteColor;
        }
        public int AddNumberOfChildren()
        {
            numberOfChildren = Convert.ToInt32("3");
            information[4] = numberOfChildren;
            return numberOfChildren;
        }
            public int AddNumberOfFamilyMembers()
        {
            numberOfFamilyMembers = Convert.ToInt32("5");
            information[5] = numberOfFamilyMembers;
            return numberOfFamilyMembers;
        }
            public int AddNumberOfPets()
        {
            numberOfPets = Convert.ToInt32("1");
            information[6] = numberOfPets;
            return numberOfPets;
        }
        public int AddAge()
        {
            age = Convert.ToInt32("28");
            information[7] = age;
            return age;
        }
        public int AddFavoriteNumber()
        {
            favoriteNumber = Convert.ToInt32("10");
            information[8] = favoriteNumber;
            return favoriteNumber;
        }
        public int AddBirthday()
        {
            birthday = Convert.ToInt32("March 5, 1988");
            information[9] = birthday;
            return birthday;
        }
    }
}
