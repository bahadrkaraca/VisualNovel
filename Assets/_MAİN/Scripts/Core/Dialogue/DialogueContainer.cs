using UnityEngine;
using TMPro;
using System.Collections;

namespace DIALOGUE
{
    [System.Serializable]
    public class DialogueContainer
    {
        public GameObject root;
        public NameContainer nameContainer = new NameContainer();
        public TextMeshProUGUI dialogueText;
    }
}
