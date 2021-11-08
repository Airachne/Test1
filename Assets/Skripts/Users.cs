using System.Collections.Generic;
using System.Xml.Serialization;

[XmlRoot]
public class Users
{
    [XmlArray("usersNames"), XmlArrayItem("name")]
    public List<string> userName;

     [XmlArray("usersAge"), XmlArrayItem("age")]

    // [XmlArrayAttribute("usersNames")]
    public List<int> userAge;

     [XmlArray("usersRelation"), XmlArrayItem("relation")]
    public List<bool> userRelation;


}

