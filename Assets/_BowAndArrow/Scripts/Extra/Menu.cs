using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Menu : MonoBehaviour, IArrowHittable
{
    public float forceAmount = 1.0f;
    public Material otherMaterial = null;
    public string scene;

    public void Hit(Arrow arrow)
    {
        ApplyMaterial();
        ApplyForce(arrow.transform.forward);
        if (scene != null)
        {
            Player.SetNbFleche(5);
            Player.SetScorePlayer(0);
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
