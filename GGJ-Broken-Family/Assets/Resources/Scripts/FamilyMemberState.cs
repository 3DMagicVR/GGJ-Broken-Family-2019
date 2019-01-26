using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FamilyMemberState : MonoBehaviour {
    public enum FamilyMember {
        Boy,
        Girl,
        Son,
        Doughter,
        Mother,
        Father,
        None
    }

    FamilyMember member = FamilyMember.None;

    private void SetViewRange () {
        
    }
}