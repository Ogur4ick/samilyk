using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


    public class playerstat : MonoBehaviour
    {
        public Text opyt;

        public static int curEXP = 0;
        public static int lvl = 1;
        public static int EXP = 10;

        void Start()
        {
            
        }
        void Update()
        {
            
            if (curEXP >= EXP)
            {
                lvl += 1;
                EXP += 10;
                curEXP = 0;
            }
        }
        
        
    }

