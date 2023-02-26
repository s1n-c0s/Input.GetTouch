using UnityEngine;

public class DrawMe : MonoBehaviour
{
    public MeshRenderer meshRenderer; // Reference to the mesh renderer component
    public Material material; // Reference to the material that you want to paint on

    private Texture2D texture; // Texture that you paint on
    private bool isPainting; // Flag to indicate if painting is in progress

    void Start()
    {
        // Create a new texture with the same dimensions as the material's main texture
        texture = new Texture2D(material.mainTexture.width, material.mainTexture.height, TextureFormat.RGBA32, false);

        // Set the new texture as the material's main texture
        meshRenderer.material.mainTexture = texture;
    }

    void OnMouseDown()
    {
        Debug.Log("paint");
        isPainting = true; // Start painting when the player clicks on the sign
    }

    void OnMouseUp()
    {
        isPainting = false; // Stop painting when the player releases the mouse button
    }

    void Update()
    {
        if (isPainting)
        {
            // Get the UV coordinates of the point that the player clicked on the sign
            RaycastHit hit;
            if (Physics.Raycast(Camera.main.ScreenPointToRay(Input.mousePosition), out hit) && hit.collider == GetComponent<Collider>())
            {
                Vector2 pixelUV = hit.textureCoord;
                pixelUV.x *= texture.width;
                pixelUV.y *= texture.height;

                // Paint a circle on the texture at the clicked point
                int brushSize = 10;
                for (int i = -brushSize; i <= brushSize; i++)
                {
                    for (int j = -brushSize; j <= brushSize; j++)
                    {
                        if (i * i + j * j <= brushSize * brushSize)
                        {
                            int x = Mathf.RoundToInt(pixelUV.x + i);
                            int y = Mathf.RoundToInt(pixelUV.y + j);
                            if (x >= 0 && x < texture.width && y >= 0 && y < texture.height)
                            {
                                texture.SetPixel(x, y, Color.red);
                            }
                        }
                    }
                }

                // Apply the changes to the texture
                texture.Apply();
            }
        }
    }
}
