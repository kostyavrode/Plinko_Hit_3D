using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AllServices
{
    private static AllServices instance;

    public static AllServices Container => instance ?? (instance = new AllServices());

    public void RegisterSingle<TService>(TService implementation) where TService : IService =>
        Implementation<TService>.ServiceInstance=implementation;

    public TService Single<TService>() where TService : IService =>
        Implementation<TService>.ServiceInstance;

    private class Implementation<TService> where TService: IService
    {
        public static TService ServiceInstance;
    }
}
