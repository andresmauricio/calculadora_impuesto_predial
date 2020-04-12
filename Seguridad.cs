using System;

class Seguridad
{
    private int PasswordCorrecto = 123;

    public bool ValidarPassword(int passwordUser)
    {
        if (PasswordCorrecto == passwordUser)
        {
            return true;
        }
        else return false;

    }


}