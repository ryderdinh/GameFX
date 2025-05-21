using System;
using UnityEngine;
using UnityEngine.Purchasing;

[CreateAssetMenu(fileName = "Product", menuName = "InApp/New Product")]
public class InAppProduct : ScriptableObject
{
	public string AndroidProductId;

	public string IosProductId;

	public ProductType Type;

	public InAppProductCategory Category;

	[NonSerialized]
	public Product Product;

	private ProductDefinition _productDefinition;

	public string ProductId => null;

	public ProductDefinition ProductDefinition => null;

	public void UpdateData(string androidProductId, string iosProductId, ProductType type)
	{
	}
}
