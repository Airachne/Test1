using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GenerateView : MonoBehaviour
{
    XMLSerializer xMLSerializer;
    Users users = XMLOp.Deserialize<Users>("users.xml"); //получение данных с xml

//    [SerializeField]
   // private Button s1Text1;//переменная для содания кнопок с именами

    public GameObject PozText; // переменная определения позиции кнопок в компоненте контент
    private Vector3 poz; // позиция сммещение
    public GameObject test; // счётчик id
    public Button button; // кнопка
    
    // Start is called before the first frame update
    void Start()
    {
        Debug.Log(users.userName.Count);
        Generate(); // функция генерации
    }

    void Generate()
    {
        //poz = new Vector3(PozText.transform.position.x, PozText.transform.position.y - 34, PozText.transform.position.z); // установка изначальной позиции
        ButtonPrefs prefs = new ButtonPrefs();
        prefs.poz = new Vector3(PozText.transform.position.x, PozText.transform.position.y - 34, PozText.transform.position.z);

        test.GetComponent<OpenPanel>().id = 0; // обнуление счётчика
        
        for (int i = 0; i <= users.userName.Count; i++) //цикл создания кнопок число которых равно колличеству запесей в файле xml
        {
            Debug.Log(users.userName[i]);
            /*  s1Text1 = Instantiate(button); //создание копки
              s1Text1.transform.SetParent(PozText.transform); // помещение кнопок в content
              s1Text1.transform.position = poz; //смещение позиции кнопки к позиции компонента content

              Init(ButtonPrefs prefs)
              poz.y -= 34; // последубщее смещение позиций кнопок */
  
            Init(prefs, i);

          //  s1Text1.GetComponentInChildren<Text>().text = users.userName[i]; // пресвоение имён из xml
         //   s1Text1.GetComponentInChildren<Text>().text += $" X={users.userAge[i]} Y={users.userRelation[i]}";
            test.GetComponent<OpenPanel>().id++; //увеличение счётчика 
            Debug.Log(users.userName.Count);
        }

    }


    public void Init(ButtonPrefs prefs, int count)
    {
        // usefulInformationText.text = payload.usefulInformation;
        //   moreUsefulInformationText.text = data.moreUsefulInformation;
        prefs.s1Text1 = Instantiate(button); //создание копки
        prefs.s1Text1.transform.SetParent(PozText.transform); // помещение кнопок в content
        prefs.s1Text1.transform.position = prefs.poz; //смещение позиции кнопки к позиции компонента content
        prefs.poz.y -= 34;
        prefs.s1Text1.GetComponentInChildren<Text>().text = users.userName[count];
    }
}

public class ButtonPrefs
{
    //  public string usefulInformation;
    // public string moreUsefulInformation;
    public Vector3 poz;
    public Button s1Text1;//переменная для содания кнопок с именами
}