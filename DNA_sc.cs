using UnityEngine;
public class DNA_sc : MonoBehaviour
{
    public float r;
    public float g;
    public float b;
    bool isDead = false;
    public float timeToDie = 0;
    SpriteRenderer sRenderer;
    Collider2D sCollider;
    //DNA_cs dosyasında boyut için değişken tanımlayalım
    public float s;
    void Start()
    {
        this.transform.localScale = new Vector3(s, s, s);
        sRenderer = GetComponent<SpriteRenderer>();
        sCollider = GetComponent<Collider2D>();
        //Renderer kullanarak rengi atayın.
        sRenderer.color = new Color(r, g, b);
    }
    void OnMouseDown()
    {
        isDead = true;
        timeToDie = PopulationManager_sc.elapsed;
        Debug.Log("Dead At: " + timeToDie);
        sRenderer.enabled = false;
        sCollider.enabled = false;
    }
    void Update()
    {
        
    }
}
