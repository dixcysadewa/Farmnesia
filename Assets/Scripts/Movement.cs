using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public float speed = 5f;
    
    // Variabel referensi ke komponen Animator
    public Animator animator; 

    private Vector3 movement;

    void Update()
    {
        // Mengambil input horizontal (A/D atau Panah Kiri/Kanan) dan vertikal (W/S atau Panah Atas/Bawah)
        movement.x = Input.GetAxisRaw("Horizontal");
        movement.y = Input.GetAxisRaw("Vertical");

        // Menggerakkan karakter berdasarkan input dan kecepatan
        transform.position += movement.normalized * speed * Time.deltaTime;

        // Memanggil fungsi untuk mengatur animasi berdasarkan arah gerakan
        AnimateMovement(movement);
    }

    void AnimateMovement(Vector3 direction)
    {
        // Memastikan referensi animator tidak kosong (null) sebelum diakses
        if (animator != null)
        {
            // Mengecek apakah karakter sedang bergerak dengan melihat nilai magnitude (panjang vektor) input
            if (direction.magnitude > 0)
            {
                // Jika bergerak, set parameter 'isMoving' menjadi true
                animator.SetBool("isMoving", true);

                // Mengirim nilai arah X dan Y ke parameter Blend Tree di Animator
                animator.SetFloat("horizontal", direction.x);
                animator.SetFloat("vertical", direction.y);
            }
            else
            {
                // Jika diam (tidak ada input), set parameter 'isMoving' menjadi false
                animator.SetBool("isMoving", false);
            }
        }
    }
}