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
            "Eve yeni gelen siyah-beyaz kedi hemen etraf� ke�fetmeye ba�lad�.",
            "�lk olarak koltu�un arkas�na sakland�, sonra televizyonun �st�ne z�plad�.",
            "Oyun oynamaya �al��t�, ama topu g�remedi�i i�in hafif�e kuyru�unu sallayarak dikkatini �ekti.",
            "Kedi, yeni �evresine al��maya �al���rken, mutfak tezgah�n�n �zerindeki �i�ekleri merakla koklad�.",
            "Ard�ndan pencere kenar�ndaki perdeyi arkas�na saklanarak d��ar�daki ku�lar� g�zlemlemeye ba�lad�."
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

            //string longLine = "Disarida yagmur yagiyordu ve cam �zerinde ince damlalar olusturuyordu. Sokakta y�r�yen insanlar semsiyelerini a�ti, bazilari hizla y�r�meye �alisti. Arabalarin lastikleri su birikintilerinden ge�erken �ikan sesler sokakta yankilaniyordu.";
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