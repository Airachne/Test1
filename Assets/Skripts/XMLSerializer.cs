using System.Collections.Generic;
using UnityEngine;

public class XMLSerializer : MonoBehaviour
{
    // Start is called before the first frame update
  //  public Users users;
  public  void Start()
    {
        Users users = new Users();

        users.userName = new List<string> { "Anton", "Boris", "Maria", "Boris", "Anton" };
       /* users.userName.Add("Anton");
        users.userName.Add("Boris");
        users.userName.Add("Maria");
        users.userName.Add("Boris");
        users.userName.Add("Anton");*/

        users.userAge = new List<int>(); // { 1, 2, 3, 4 };
        users.userAge.Add(37);
        users.userAge.Add(30);
        users.userAge.Add(35);
        users.userAge.Add(22);
        users.userAge.Add(22);

        users.userRelation = new List<bool>();// { true, false, true, false };
        users.userRelation.Add(true);
        users.userRelation.Add(false);
        users.userRelation.Add(false);
        users.userRelation.Add(false);
        users.userRelation.Add(true);



    XMLOp.Serialize(users, "users.xml");
    }


}
