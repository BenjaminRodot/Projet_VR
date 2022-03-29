using TMPro;
using UnityEngine;

public class Target : MonoBehaviour, IArrowHittable
{
    public float forceAmount = 1.0f;
    public Material otherMaterial = null;
    public int score = 1;

    public void Hit(Arrow arrow)
    {
        
        if (Player.GetNbFleche() > 0)
        {
            ApplyMaterial();
            ApplyForce(arrow.transform.forward);
            Player.SetNbFleche(Player.GetNbFleche() - 1);
            Player.SetScorePlayer(Player.GetScorePlayer() +score);
            GameObject.Find("AffichageScore").GetComponent<TextMeshPro>().text = Player.GetScorePlayer().ToString();
            if (Player.GetNbFleche() == 1)
            {
                GameObject.Find("AffichageFleche").GetComponent<TextMeshPro>().text = "Fleche restante : 1";
            }
            else
            {
                GameObject.Find("AffichageFleche").GetComponent<TextMeshPro>().text = "Fleches restantes : "+Player.GetNbFleche().ToString();
            }
            
        }
        
    }

    private void ApplyMaterial()
    {
        MeshRenderer meshRenderer = GetComponentInChildren<MeshRenderer>();
        meshRenderer.material = otherMaterial;
    }

    private void ApplyForce(Vector3 direction)
    {
        Rigidbody rigidbody = GetComponent<Rigidbody>();
        rigidbody.AddForce(direction * forceAmount);
    }
}
