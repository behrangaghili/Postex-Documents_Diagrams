interface User{


    /// <summary>
    ///  Login a user with Username and password
    /// </summary>
    /// <param name="username"></param>
    /// <param name="password"></param>
    /// <returns>If User is Authenticated returns True </returns>
    bool Login(string username,string password);


}