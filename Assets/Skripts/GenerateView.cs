using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GenerateView : MonoBehaviour
{
    XMLSerializer xMLSerializer;
    Users users = XMLOp.Deserialize<Users>("users.xml"); //��������� ������ � xml

//    [SerializeField]
   // private Button s1Text1;//���������� ��� ������� ������ � �������

    public GameObject PozText; // ���������� ����������� ������� ������ � ���������� �������
    private Vector3 poz; // ������� ���������
    public GameObject test; // ������� id
    public Button button; // ������
    
    // Start is called before the first frame update
    void Start()
    {
        Debug.Log(users.userName.Count);
        Generate(); // ������� ���������
    }

    void Generate()
    {
        //poz = new Vector3(PozText.transform.position.x, PozText.transform.position.y - 34, PozText.transform.position.z); // ��������� ����������� �������
        ButtonPrefs prefs = new ButtonPrefs();
        prefs.poz = new Vector3(PozText.transform.position.x, PozText.transform.position.y - 34, PozText.transform.position.z);

        test.GetComponent<OpenPanel>().id = 0; // ��������� ��������
        
        for (int i = 0; i <= users.userName.Count; i++) //���� �������� ������ ����� ������� ����� ����������� ������� � ����� xml
        {
            Debug.Log(users.userName[i]);
            /*  s1Text1 = Instantiate(button); //�������� �����
              s1Text1.transform.SetParent(PozText.transform); // ��������� ������ � content
              s1Text1.transform.position = poz; //�������� ������� ������ � ������� ���������� content

              Init(ButtonPrefs prefs)
              poz.y -= 34; // ����������� �������� ������� ������ */
  
            Init(prefs, i);

          //  s1Text1.GetComponentInChildren<Text>().text = users.userName[i]; // ���������� ��� �� xml
         //   s1Text1.GetComponentInChildren<Text>().text += $" X={users.userAge[i]} Y={users.userRelation[i]}";
            test.GetComponent<OpenPanel>().id++; //���������� �������� 
            Debug.Log(users.userName.Count);
        }

    }


    public void Init(ButtonPrefs prefs, int count)
    {
        // usefulInformationText.text = payload.usefulInformation;
        //   moreUsefulInformationText.text = data.moreUsefulInformation;
        prefs.s1Text1 = Instantiate(button); //�������� �����
        prefs.s1Text1.transform.SetParent(PozText.transform); // ��������� ������ � content
        prefs.s1Text1.transform.position = prefs.poz; //�������� ������� ������ � ������� ���������� content
        prefs.poz.y -= 34;
        prefs.s1Text1.GetComponentInChildren<Text>().text = users.userName[count];
    }
}

public class ButtonPrefs
{
    //  public string usefulInformation;
    // public string moreUsefulInformation;
    public Vector3 poz;
    public Button s1Text1;//���������� ��� ������� ������ � �������
}