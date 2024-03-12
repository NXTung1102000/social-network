namespace Model.Enum
{
    public enum RelationShipEnum
    {
        Block = -1,     // user_1 block user_2
        None = 0,
        IsFriend = 1,   
        Send = 2,       // user_1 send friend request to user_2
        Receive = 3     // user_1 receive friend request from user_2
    }
}
