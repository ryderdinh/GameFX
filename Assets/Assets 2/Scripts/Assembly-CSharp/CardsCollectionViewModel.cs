using System;
using System.Collections.Generic;

public struct CardsCollectionViewModel
{
	public List<CardsToAddData> CardsToAdd;

	public ResourcesTexture CardsTexture;

	public Action Callback;

	public bool AnimateAfterClaim;
}
