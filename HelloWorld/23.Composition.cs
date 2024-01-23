using System;
public class AuthController
{
    private HttpCookie _cookie;

    public AuthController(HttpCookie cookieInstance)
    {
        _cookie = cookieInstance;
    }

    public void InitializeController()
    {
        _cookie["token"] = "verysecuretokel";
        _cookie.Expiry = DateTime.Now.AddDays(3);
    }

    public HttpCookie SendCookie()
    {
        return _cookie;
    }
}

/* In composition, a class is not directly tied to another class, instead,
 * it accepts a class which extends its functionality as an argument.
 * 
 * Composition follows a "has-a" relationship
 * Example: An auth controller has a cookie.
 */