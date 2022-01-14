using System;
using System.Collections.Generic;
using UnityEngine;

public abstract class ViewBase : MonoBehaviour
{
    protected readonly List<IDisposable> _disposables = new List<IDisposable>();

    protected virtual void OnDestroy()
    {
        foreach (var disposable in _disposables)
        {
            disposable.Dispose();
        }

        _disposables.Clear();
    }
}