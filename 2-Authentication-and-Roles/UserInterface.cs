interface User{


    /// <summary>
    ///  Login a user with Username and password
    /// </summary>
    /// <param name="username"></param>
    /// <param name="password"></param>
    /// <returns>If User is Authenticated returns True </returns>
    bool Login(string username,string password);

     /// <summary>
    ///  signup user with PhoneNumber , National Code and password
    /// </summary>
    /// <param number="PhoneNumber"></param>
    /// <param number="NationalCode"></param>
    /// <param name="password"></param>
     /// <param name="Code"></param>
    /// <returns>If User is Code returns True </returns>
    bool SingUp(int PhoneNumber, int NationalCode ,string password);


    string ChangePassword(string CurrentPassWprd ,string NewPassword);


}

}
