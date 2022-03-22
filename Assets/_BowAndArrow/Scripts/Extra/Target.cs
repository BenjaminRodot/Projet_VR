using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Target : MonoBehaviour, IArrowHittable
{
    public float forceAmount = 1.0f;
    public Material otherMaterial = null;
    public int score = 1;
    public string scene;

    public void Hit(Arrow arrow)
    {
        ApplyMaterial();
        ApplyForce(arrow.transform.forward);
        Player.SetScorePlayer(score);
        GameObject.Find("AffichageScore").GetComponent<TextMeshPro>().text = Player.GetScorePlayer().ToString();
        if(scene != null)
        {
            SceneManager.LoadScene(scene, LoadSceneMode.Single);
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
