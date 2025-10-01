using UnityEngine;
using DG.Tweening;

public class DroneController : MonoBehaviour
{
    public float animationTime = 3f;
    private Vector3 startRotation = new Vector3(0, -25, 0);
    private Vector3 endRotation = new Vector3(0, 25, 0);
    private Vector3 startPosition = new Vector3(-1.5f, 1f, 1.2f);
    private Vector3 endPosition = new Vector3(-1f, 2f, 1.2f);

    void Start()
    {
        RotateAndMoveDrone();
    }
    void RotateAndMoveDrone()
    {
        transform.DOLocalRotate(endRotation, animationTime).SetEase(Ease.Linear).OnComplete(() =>
        {
            SwapRotations();
            transform.DOLocalRotate(startRotation, animationTime).SetEase(Ease.Linear);
        });

        transform.DOLocalMove(endPosition, animationTime).SetEase(Ease.Linear).OnComplete(() =>
        {
            SwapPositions();
            transform.DOLocalMove(startPosition, animationTime).SetEase(Ease.Linear).OnComplete(() =>
            {
                RotateAndMoveDrone();
            });
        });
    }
    
    void SwapRotations()
    {
        Vector3 temp = startRotation;
        startRotation = endRotation;
        endRotation = temp;
    }
    
    void SwapPositions()
    {
        Vector3 temp = startPosition;
        startPosition = endPosition;
        endPosition = temp;
    }
}
