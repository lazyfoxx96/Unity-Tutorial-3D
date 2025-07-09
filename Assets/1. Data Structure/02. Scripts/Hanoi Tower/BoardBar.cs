using System.Collections.Generic;
using UnityEngine;

public class BoardBar : MonoBehaviour
{
    public enum BarType { Left, Center, Right };
    public BarType barType;

    public Stack<GameObject> barStack = new Stack<GameObject>();

    private void OnMouseDown()
    {
        if(!HanoiTower.isSelected)
        {
            HanoiTower.isSelected = true;
            HanoiTower.selectedDonut = PopDonut();
        }
        else
        {
            PushDonut(HanoiTower.selectedDonut);
        }
    }

    public bool CheckDonut(GameObject donut)
    {
        if(barStack.Count > 0)
        {
            int pushNumber = donut.GetComponent<Donut>().donutNumber;
            GameObject peekDonut = barStack.Peek();
            int peekNumber = peekDonut.GetComponent<Donut>().donutNumber;

            bool Check;

            Check = pushNumber < peekNumber ? true : false;

            return Check;
        }

        return true;
    }

    public void PushDonut(GameObject donut)
    {
        if(!CheckDonut(donut))
        {
            return;
        }

        HanoiTower.isSelected = false;
        HanoiTower.selectedDonut = null;

        donut.transform.position = transform.position + Vector3.up * 7f;
        donut.GetComponent<Rigidbody>().linearVelocity = Vector3.zero;
        donut.GetComponent<Rigidbody>().angularVelocity = Vector3.zero;

        barStack.Push(donut);
    }

    public GameObject PopDonut()
    {
        GameObject donut = barStack.Pop();

        return donut;
    }
}
