using UnityEngine;

public class CoinsPresenter : MonoBehaviour
{
    [SerializeField] private Coins _coins;
    [SerializeField] private Animator _animator;
    
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag.Contains("Coin"))
        {
            _coins.OnPickupCoin();
            _animator.SetTrigger("OnPickupCoin");
        }
    }
}
