using System;

namespace Code_Generator
{
    
    public class clsGenerated
    {


      //  public enum enMode { AddNew = 0, Update = 1 };

        //enMode Mode;
        //public int GeneratedID { get; set; }
        //public string Name { get; set; }
        //public string Phone { get; set; }
        //public string Email { get; set; }
        //public string PinCode { get; set; }

        //public clsGenerated()
        //{

        //    this.GeneratedID = -1;
        //    this.Name = "";
        //    this.Phone = "";
        //    this.Email = "";
        //    this.PinCode = "";

        //    Mode = enMode.AddNew;

        //}

        //public clsGenerated(int ID, string Name, string Phone, string Email, string PinCode)
        //{

        //    this.GeneratedID = ID;
        //    this.Name = Name;
        //    this.Phone = Phone;
        //    this.Email = Email;
        //    this.PinCode = PinCode;

        //    Mode = enMode.Update;



        //}

        //public static clsGenerated Find(int ID)
        //{

        //    string Name = "", Phone = "", Email = "", PinCode = "";


        //    if (clsGeneratedDataAccess.GetGeneratedInfoByID(ID, ref Name, ref Phone, ref Email, ref PinCode))
        //    {
        //        return new clsGenerated(ID, Name, Phone, Email, PinCode);
        //    }
        //    else
        //    {
        //        return null;
        //    }
        //}

        //private bool _AddNewGenerated()
        //{
        //    this.GeneratedID = clsGeneratedDataAccess.AddNewGenerated(Name, Phone, Email, PinCode);


        //    return (this.GeneratedID != -1);

        //}

        //private bool _UpdateGenerated()
        //{

        //    return clsGeneratedDataAccess.UpdateGenerated(this.GeneratedID, this.Name, this.Phone, this.Email, this.PinCode);
        //}

        //public virtual bool Save()
        //{

        //    switch (Mode)
        //    {

        //        case enMode.AddNew:

        //            if (_AddNewGenerated())
        //            {

        //                Mode = enMode.Update;
        //                return true;
        //            }
        //            else
        //            {
        //                return false;
        //            }

        //        case enMode.Update:
        //            return _UpdateGenerated();
        //    }

        //    return false;
        //}


        //public static bool IsGeneratedExist(int ID)
        //{
        //    return clsGeneratedDataAccess.IsGeneratedExist(ID);
        //}

        //public static bool DeleteGenerated(int ID)
        //{
        //       return clsGeneratedDataAccess.DeleteGenerated(ID);
        //}

    }

}
