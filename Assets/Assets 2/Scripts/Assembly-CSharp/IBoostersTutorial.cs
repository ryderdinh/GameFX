using UnityEngine;

public interface IBoostersTutorial
{
	Vector3 GetPositionAgainstSlotID(int id);

	Vector3 GetPositionAgainstTrayID(int id);

	TutorialController GetTutorialController();
}
