using JaLoader;
using System.Collections.Generic;
using UnityEngine;

namespace BetterSuspension
{
    public class BetterSuspension : Mod
    {
        public override string ModID => "BetterSuspension";
        public override string ModName => "Better Suspension";
        public override string ModAuthor => "Leaxx";
        public override string ModDescription => "Makes the Laika's suspension softer.";
        public override string ModVersion => "1.0";
        public override string GitHubLink => "https://github.com/Jalopy-Mods/BetterSuspension";
        public override WhenToInit WhenToInit => WhenToInit.InGame;
        public override List<(string, string, string)> Dependencies => new List<(string, string, string)>();

        public override bool UseAssets => false;

        public override void Start()
        {
            base.Start();

            FindObjectOfType<CarCollisionsC>().fineVelocity = 10; 
            FindObjectOfType<AntiRoll>().antiRollVal = 10000;

            ModHelper.Instance.laika.GetComponent<Rigidbody>().mass = 2400;
            ModHelper.Instance.laika.GetComponent<Rigidbody>().centerOfMass = new Vector3(0, -1.5f, 1.2f);

            FindObjectOfType<CarControleScriptC>().centerOfMass = new Vector3(0, - 3, 1);
        }
    }
}
