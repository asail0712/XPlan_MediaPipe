using UnityEngine;
using System.Collections.Generic;

namespace XPlan.ImageRecognize.HumanJoint
{
    public class HeadJointFactory 
    {
        NeckJointCalculator neckJointCalculator;

        public HeadJointFactory (Animator anim)
        {
            neckJointCalculator = new NeckJointCalculator(
                anim.GetBoneTransform(HumanBodyBones.Neck)
            );
        }

        public HashSet<HumanJointCalculator> Generate ()
        {
            HashSet<HumanJointCalculator> calculators = new HashSet<HumanJointCalculator>();
            calculators.Add(neckJointCalculator);

            return calculators;
        }
    }
};
