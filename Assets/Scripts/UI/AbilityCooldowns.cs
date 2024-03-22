using UnityEngine;
using UnityEngine.UI;

public class AbilityCooldowns : MonoBehaviour
{
    [SerializeField] PlayerInputHandler playerInputHandler;
    [SerializeField] Text cooldownText;

    void Update()
    {
        float rollCooldown = playerInputHandler.GetRollRemainingCooldown();
        cooldownText.text = rollCooldown.ToString("F0");
    }
}