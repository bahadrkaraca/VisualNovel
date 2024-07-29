using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DIALOGUE;

namespace TESTING
{
    public class Testing_Architect : MonoBehaviour
    {
        DialogueSystem ds;
        TextArchitect architect;

        public TextArchitect.BuildMethod bm = TextArchitect.BuildMethod.instant;

        string[] lines = new string[5]
        {
            "Eve yeni gelen siyah-beyaz kedi hemen etrafý keþfetmeye baþladý.",
            "Ýlk olarak koltuðun arkasýna saklandý, sonra televizyonun üstüne zýpladý.",
            "Oyun oynamaya çalýþtý, ama topu göremediði için hafifçe kuyruðunu sallayarak dikkatini çekti.",
            "Kedi, yeni çevresine alýþmaya çalýþýrken, mutfak tezgahýnýn üzerindeki çiçekleri merakla kokladý.",
            "Ardýndan pencere kenarýndaki perdeyi arkasýna saklanarak dýþarýdaki kuþlarý gözlemlemeye baþladý."
        };
        // Start is called before the first frame update
        void Start()
        {
            ds = DialogueSystem.instance;
            architect = new TextArchitect(ds.dialogueContainer.dialogueText);
            //architect.buildMethod = TextArchitect.BuildMethod.typewriter;
            architect.buildMethod = TextArchitect.BuildMethod.fade;
            architect.speed = 0.5f;
        }

        // Update is called once per frame
        void Update()
        {
            if (bm != architect.buildMethod)
            {
                architect.buildMethod = bm;
                architect.Stop();
            }

            if (Input.GetKeyDown(KeyCode.S))
                architect.Stop();

            //string longLine = "Disarida yagmur yagiyordu ve cam üzerinde ince damlalar olusturuyordu. Sokakta yürüyen insanlar semsiyelerini açti, bazilari hizla yürümeye çalisti. Arabalarin lastikleri su birikintilerinden geçerken çikan sesler sokakta yankilaniyordu.";
            if (Input.GetKeyDown(KeyCode.Space))
            {
                if (architect.isBuilding)
                {
                    if (!architect.hurryUp)
                        architect.hurryUp = true;
                    else
                        architect.ForceComplete();
                }
                else
                    //architect.Build(longLine);
                    architect.Build(lines[Random.Range(0, lines.Length)]);
            }
            else if(Input.GetKeyDown(KeyCode.A))
            {
                //architect.Append(longLine);
                architect.Append(lines[Random.Range(0, lines.Length)]);
            }
        }
    }
}