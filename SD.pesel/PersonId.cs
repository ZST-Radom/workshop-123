﻿namespace SD.pesel;

public class PersonId
{
    private readonly string _id;

    public PersonId(string Id)
    {
        _id = Id;
    }

    /// <summary>
    /// Get full year from PESEL
    /// </summary>
    /// <returns></returns>
    public int GetYear()
    {
        return 0;
    }

    /// <summary>
    /// Get month from PESEL
    /// </summary>
    public int GetMonth()
    {
        return 0;
    }

    /// <summary>
    /// Get day from PESEL
    /// </summary>
    /// <returns></returns>
    public int GetDay()
    {
        string id = _id;
        string result = id.Substring(4, 2);
        int resultInt = int.Parse(result);

        return resultInt;
    }

    /// <summary>
    /// Get age from PESEL
    /// </summary>
    /// <returns></returns>
    public int GetAge()
    {
        return 0;
    }

    /// <summary>
    /// Get gender from PESEL
    /// </summary>
    /// <returns>m</returns>
    /// <returns>k</returns>
    public string GetGender()
    {
        return "";
    }

    /// <summary>
    /// check if PESEL is valid
    /// </summary>
    /// <returns></returns>
    public bool IsValid()
    {
        return true;
    }
}