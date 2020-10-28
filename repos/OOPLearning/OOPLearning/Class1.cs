using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPLearning
{
    public class Class1
    {
    }

    public class Person
    {        
        string Name
        {
            //Gets the current assigned value of Name
            get { return Name; }
            //Sets the value of Name
            set 
            {
                //Checks if the value is null, if it is, then it returns an error message
                if (String.IsNullOrWhiteSpace(Name) == true)
                {
                    Name = "Name is null";
                }
                //Checks if the value has more than one character and that it contains a WhiteSpace
                else if ((Name.Count() > 1) && Name.Contains(" ") == true)
                {
                    //Trims the start of the word, so there isn't whitespace before the word
                    Name.TrimStart(' ');
                    //Trims the end of the word, so there isn't whitespace before the word
                    Name.TrimEnd(' ');
                    //sets the value of the name string
                    Name = value;
                }
            }
        }
        
        DateTime Birthday
        {
            //Gets the value of Birthday
            get
            {
                //returns the cpr number as a date
                return DateTime.Parse(Cpr.Substring(0,6));                
            }
        }

        string Cpr
        {
            //gets the currently assigned value of Cpr
            get { return Cpr; }
            //sets the value of cpr
            set 
            {
                //Checks if there is a null or whitespace
                if (String.IsNullOrWhiteSpace(Cpr) == true)
                {
                    Cpr = "Cpr is null";
                }
                //Checsk that cpr is exactly 10 numbers long
                else if ((Cpr.Count() == 10) && 
                    //tries to Convert the cpr number to a date, only if possible
                    DateTime.TryParse(Cpr.Substring(0,5),out _) == true && 
                    //Check that the cpr numbers date doesn't match today or the future
                    !(int.Parse(Cpr.Substring(0,5)) >= int.Parse(DateTime.Today.ToShortDateString())))
                {
                    //Assigns the value of Cpr
                    Cpr = value;
                }
            }
        }

        bool IsWoman
        {
            get 
            {
                //Checks if the last digit is an equal number
                if (int.Parse(Cpr.Substring(8,1)) % 2 == 0)
                {
                    //Returns true because you can divide the Cprnumber by 2 without a rest
                    return true;
                }
                else
                {
                    //Returns false because it is not a woman if you can't divide the last number of the Cprnumber
                    return false;
                }
            }
        }
    }

    public class Account
    {
        string AccountNumber
        {
            //Gets the assigned value of Accountnumber
            get
            {
                //Returns the account number
                return AccountNumber;
            }
            //Sets the value of Accountnumber
            set
            {
                //Checks if the accountnumber is null or empty, if it isn't and the length of characters is 10. Then sets the accountnumber
                if (!String.IsNullOrEmpty(AccountNumber) && AccountNumber.Length == 10)
                {
                    AccountNumber = value;
                }
            }
        }

        string DepartmentNumber
        {
            //Gets the assigned value of Departmentnumber
            get
            {
                //Returns departmentnumber
                return DepartmentNumber;
            }
            //Sets the assigned value of departmentnumber
            set
            {
                //Checks that the departmentnumber isn't null or empty, and that the length of characters is 4, and that it doesn't start with 0
                if (!String.IsNullOrEmpty(DepartmentNumber) && DepartmentNumber.Length == 4 && !DepartmentNumber.StartsWith("0"))
                {
                    DepartmentNumber = value;
                }
            }
        }

        decimal Balance
        {
            //Gets the current assigned value of Balance
            get
            {
                //returns the value of Balance
                return Balance;
            }
            set
            {
                //Checks that the balance isn't less than 0
                if (Balance >= 0)
                {
                    Balance = value;
                }
                else
                {
                    
                }
            }
        }
    }

    public class Field
    {
        double Width
        {
            //Gets the value of Width
            get
            {
                //returns the value if it is bigger than 0
                if (Width > 0)
                {
                    return Width;
                }
                else
                {
                    return 0;
                }
            }
            //Sets the value of width
            set
            {
                //Only if it is over 0
                if (Width > 0)
                {
                    Width = value;
                }
            }
        }
        double Length
        {
            //gets the value of Length
            get
            {
                //Only if length is over 0
                if (Length > 0)
                {
                    return Length;
                }
                else
                {
                    return 0;
                }
            }
            //Sets the value of length
            set
            {
                //Only if length is over 0
                if (Length > 0)
                {
                    Length = value;
                }
            }
        }
        double Area
        {
            //Gets the area by multiplying Length and Width
            get
            {
                if (Width > 0 || Length > 0 && !(Length == 0) && !(Width == 0))
                {
                    return Length * Width;
                }
                else
                {
                    //returns an exception if it can't do the calculation
                    new InvalidOperationException();
                    return 1;
                }
            }            
        }
        string Crop
        {
            //Gets the currently assigned value of Crop
            get
            {
                return Crop;
            }
            //Sets the value of Crop
            set
            {
                //Checks that the string isn't null or empty
                if (!String.IsNullOrEmpty(Crop))
                {
                    //Switch case with the options you can choose
                    //Making the string lowercase for easier and denser code
                    switch (Crop.ToLower())
                    {
                        case "potatoes":
                            Crop = "Potatoes";
                            break;
                        case "Wheat":
                            Crop = "Wheat";
                            break;
                        case "Oak":
                            Crop = "Oak";
                            break;
                        case "Carrots":
                            Crop = "Carrots";
                            break;
                        default:
                            break;
                    }
                }
            }
        }
        double Yield
        {
            //Gets the Yield value by multiplying area by the crop yield rates
            get
            {
                //Switch case for each option
                switch (Crop)
                {
                    case "Potatoes":
                        return Area * 4;                        
                    case "Wheat":
                        return Area * 2;
                    case "Oak":
                        return Area * 1.5;
                    case "Carrots":
                        return Area * 6.6;
                    default:
                        return 0;
                }
            }
        }
    }
}
