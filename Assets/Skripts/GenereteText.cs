using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class GenereteText : MonoBehaviour
{
    XMLSerializer xMLSerializer;
    Users users = XMLOp.Deserialize<Users>("users.xml");

    //private Text s1Text; //переменная для содания теста с именами
    public Text text;//  теста 
    GameObject PozText;// переменная определения позиции объектов в компоненте контент
    //private Vector3 poz;// позиция сммещение
    public Button button; // переменная определения позиции кнопок в компоненте контент
    // Button button1;// кнопка
    public GameObject test;
    GameObject panel; //панель

    // Start is called before the first frame update
    void Start()
    {
        panel.SetActive(false);

    }

    void Awake()
    {
        panel = GameObject.Find("Panel"); 
        PozText = GameObject.Find("Content (1)");
    }

    public void Generate()
    {
        panel.SetActive(true);
        SomeUsefulPayload payload = new SomeUsefulPayload();
        Init(payload);

     /*   poz = new Vector3(PozText.transform.position.x, PozText.transform.position.y - 34, PozText.transform.position.z);
      
     //   Debug.Log(users.userName[test.GetComponent<OpenPanel>().id]);
        s1Text = Instantiate(text);
    
        s1Text.transform.SetParent(PozText.transform);
        s1Text.transform.position = poz;

        poz.y -= 34;
        button1 = Instantiate(button);
        button1.transform.SetParent(PozText.transform);
        button1.transform.position = poz;
        s1Text.text = $"Name = {users.userName[test.GetComponent<OpenPanel>().id]}, Age = {users.userAge[test.GetComponent<OpenPanel>().id]}, Relation = {users.userRelation[test.GetComponent<OpenPanel>().id]}";
        */
     //  Debug.Log(users.userName.Count);

    }


     public void deletedText()
    {
        panel = GameObject.Find("Panel");
        //  Destroy(button1);
        //  Destroy(s1Text);
        Destroy(GameObject.Find("Text(Clone)"));
        Destroy(GameObject.Find("Button1(Clone)"));
        panel.SetActive(false);
    }



    public void Init(SomeUsefulPayload payload)
    {
        // usefulInformationText.text = payload.usefulInformation;
        //   moreUsefulInformationText.text = data.moreUsefulInformation;

        payload.poz = new Vector3(PozText.transform.position.x, PozText.transform.position.y - 34, PozText.transform.position.z);

        //   Debug.Log(users.userName[test.GetComponent<OpenPanel>().id]);
        payload.s1Text = Instantiate(text);

        payload.s1Text.transform.SetParent(PozText.transform);
        payload.s1Text.transform.position = payload.poz;

        payload.poz.y -= 34;
        payload.button1 = Instantiate(button);
        payload.button1.transform.SetParent(PozText.transform);
        payload.button1.transform.position = payload.poz;

        payload.userName = users.userName[test.GetComponent<OpenPanel>().id];
        payload.userAge = users.userAge[test.GetComponent<OpenPanel>().id];
        payload.userRelation = users.userRelation[test.GetComponent<OpenPanel>().id];

      payload.s1Text.text = $"Name = {payload.userName}, Age = {payload.userAge}, Relation = {payload.userRelation}";
    }
  

}
public class SomeUsefulPayload
{
    //  public string usefulInformation;
    // public string moreUsefulInformation;

    public Text s1Text; //переменная для содания теста с именами
    public Vector3 poz;// позиция сммещение
    public Button button1;// кнопка
    public string userName;
    public int userAge;
    public bool userRelation;
}

