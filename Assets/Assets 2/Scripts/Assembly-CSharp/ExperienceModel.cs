public struct ExperienceModel
{
	public int Level;

	public ExperienceViewDataModel ExpDataModel;

	public ExperienceModel(int level, ExperienceViewDataModel dataModel)
	{
		Level = 0;
		ExpDataModel = default(ExperienceViewDataModel);
	}
}
