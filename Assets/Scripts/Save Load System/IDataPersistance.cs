namespace Save_Load_System
{
    public interface IDataPersistance
    {
        public void LoadData(GameData data);

        public void SaveData(GameData data);
    }
}
