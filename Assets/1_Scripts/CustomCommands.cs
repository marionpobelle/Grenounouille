using System.Diagnostics;
using UnityEngine;
using Yarn.Unity;

public class CustomCommands : MonoBehaviour
{
    public DialogueRunner dialogueRunner;

    public void Awake()
    {
        dialogueRunner.AddCommandHandler<string>(
            "play_audio",
            PlayFromAudioHandler 
        );
    }

    private void PlayFromAudioHandler(string s)
    {
        AudioHandler.Instance.Play(s);
    }
}
