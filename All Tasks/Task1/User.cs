using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1
{
    class User
    {
        private string firstName;
        private string lastName;
        private string middleName;
        private int age;
        private Gender gender;
        private string job;
        private string education;
        private MarriedStatus maritalStatus;

        public string FirstName
        {
            set
            {
                if (value == "" || value == null)
                {
                    throw new Exception("First Name is empty");
                }
                else if(value.Length > 100 && value[0] != value.ToUpper()[0])
                {

                    throw new Exception("First letter must start with a capital letter");
                }
                firstName = value;
            }
            get
            {
                return firstName;
            }
        }
        public string LastName
        {
            set
            {
                if (value == "" || value == null)
                {
                    throw new Exception("Last Name is empty");
                }
                else if (value.Length > 100 && value[0] != value.ToUpper()[0])
                {

                    throw new Exception("First letter must start with a capital letter");
                }
                lastName = value;
            }
            get
            {
                return lastName;
            }
        }
        public string MiddleName
        {
            set
            {
                if (value == "" || value == null)
                {
                    throw new Exception("Middle Name is empty");
                }
                else if (value.Length > 100 && value[0] != value.ToUpper()[0])
                {

                    throw new Exception("First letter must start with a capital letter");
                }
                middleName = value;
            }
            get
            {
                return middleName;
            }
        }
        public int Age
        {
            set
            {
                if (age<0 && age >120)
                {
                    throw new Exception("Age is invalid. Age has value between 0 and 120");
                }
                age = value;
            }
            get
            {
                return age;
            }
        }
        public Gender Gender
        {
            set
            {
                if (value != Gender.Male && value != Gender.Female)
                {
                    throw new Exception("Gender is required");
                }
                gender = value;
            }
            get
            {
                return gender;
            }
        }
        public string Job
        {
            set
            {
                if (value == "" || value == null)
                {
                    throw new Exception("Job is required");
                }
                else if (value.Length > 300)
                {
                    throw new Exception("Job length must be less than 300");
                }
                job = value;
            }
            get
            {
                return job;
            }
        }
        public string Education
        {
            set
            {
                if (value == "" || value == null)
                {
                    throw new Exception("Job is required");
                }
                else if (value.Length > 300)
                {
                    throw new Exception("Education length must be less than 300");
                }
                education = value;
            }
            get
            {
                return education;
            }
        }
        public MarriedStatus MaritalStatus
        {
            set
            {
                if (value != MarriedStatus.Married && value != MarriedStatus.Divorced && value != MarriedStatus.NotMarried)
                {
                    throw new Exception("MaritalStatus is required");
                }
                maritalStatus = value;
            }
            get
            {
                return maritalStatus;
            }
        }
    }
    enum Gender
    {
        Male,
        Female
    }
    enum MarriedStatus
    {
        Married,
        Divorced,
        NotMarried
    }
}
