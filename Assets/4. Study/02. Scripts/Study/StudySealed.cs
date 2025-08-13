using UnityEngine;

public class ParentClass : MonoBehaviour
{
    public virtual void Method()
    {

    }
}

public class StudySealed : ParentClass
{
    public sealed override void Method()
    {
        base.Method();
    }
}

public class ChildClass : StudySealed
{
    //public override void Method()
    //{
        
    //}
}
