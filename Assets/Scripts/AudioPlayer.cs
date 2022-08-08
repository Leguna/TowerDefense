using System.Collections.Generic;
using UnityEngine;

public class AudioPlayer : SingletonMonoBehaviour<AudioPlayer>
{
    [SerializeField] private AudioSource _audioSource;
    [SerializeField] private List<AudioClip> _audioClips;

    public void PlaySFX(string name)
    {
        AudioClip sfx = _audioClips.Find(s => s.name == name);
        if (sfx == null)
        {
            return;
        }

        _audioSource.PlayOneShot(sfx);
    }
}