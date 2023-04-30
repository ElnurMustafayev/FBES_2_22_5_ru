namespace PropertiesApp;

public class Person {

    private int age;
    private bool hasDriverLicense;

    public string Name { get; set; }
    public string Surname { get; set; }
    public int Age {
        get => age;
        set {
            this.age = (value > 0) ? value : throw new Exception("Age can not be less than 0!");
        }
    }
    public bool HasDriverLicense { 
        get => hasDriverLicense; 
        set {
            if (this.Age < 18 && value == true)
                throw new Exception($"Only Adult people can have DriverLicense! Current age: {this.Age}");

            this.hasDriverLicense = value;
        } 
    }

    public bool IsAdult => this.Age >= 18;
}

public class Car {
    private Person driver;
    private string number;


    public Person Driver {
        get => driver;
        set {
            if (value == null) {
                this.driver = null;
                return;
            }
            if (string.IsNullOrWhiteSpace(value.Name))
                throw new Exception($"Driver's {nameof(value.Name).ToLower()} can not be empty!");

            if (string.IsNullOrWhiteSpace(value.Surname))
                throw new Exception($"Driver's {nameof(value.Surname).ToLower()} can not be empty!");

            if (value.IsAdult == false)
                throw new Exception("Driver is not Adult!");

            if(value.HasDriverLicense == false)
                throw new Exception("Driver doesn't have DriverLicense!");

            this.driver = value;
        }
    }

    public string Number {
        get => this.number;
        set {
            if(string.IsNullOrWhiteSpace(value)) {
                this.number = null;
                return;
            }

            // normalize
            value = value.Trim().ToLower();

            // "99AA777"
            if (value.Length != 7)
                throw new Exception("Car number's length is not 7!");

            // 99
            if(uint.TryParse(value[..2], out uint regionNum) == false)
                throw new Exception($"The '{nameof(regionNum)}' must be numeric!");
            
            // AA
            string serialCode = value[2..4];
            for (int i = 0; i < serialCode.Length; i++)
                if (char.IsLetter(serialCode[i]) == false)
                    throw new Exception($"{nameof(serialCode)} has a non-letter symbol!");

            // 777
            if (uint.TryParse(value[4..], out uint serialNumber) == false)
                throw new Exception($"The '{nameof(serialNumber)}' must be numeric!");

            this.number = value;
        }
    }
}