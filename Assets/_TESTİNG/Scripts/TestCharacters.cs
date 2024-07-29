using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using CHARACTERS;

namespace TESTING
{
    public class TestCharacters : MonoBehaviour
    {
        // Start is called before the first frame update
        void Start()
        {
            Character Habib = CharacterManager.instance.CreateCharacter("Habib");
            Character Murtaza = CharacterManager.instance.CreateCharacter("Murtaza");
            Character Murtaza2 = CharacterManager.instance.CreateCharacter("Murtaza");
            Character Adam = CharacterManager.instance.CreateCharacter("Adam");
        }

        // Update is called once per frame
        void Update()
        {

        }
    }
}