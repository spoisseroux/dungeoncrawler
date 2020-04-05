using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Wall : MonoBehaviour
{
    public Sprite dmgSprite;
    public int hp = 4;

    private SpriteRenderer spriteRenderer;
    public AudioClip damageSound1;
    public AudioClip damageSound2;

    // Start is called before the first frame update
    void Awake()
    {
        spriteRenderer = GetComponent<SpriteRenderer>();
    }

    public void DamageWall(int loss) {
        SoundManager.instance.RandomizeSfx(damageSound1, damageSound2);
        spriteRenderer.sprite = dmgSprite;
        hp -= loss; 
        if (hp <= 0) {
            gameObject.SetActive(false);
        }
    }


}
