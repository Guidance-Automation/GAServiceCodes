namespace ServiceCodeSupport.Architecture
{
    public enum ErrorCode
    {
        // Job Builder specific
        JobBuilder_Job_Id_Commit_Failed = 1001,
        JobBuilder_Job_Id_Invalid = 1002,
        JobBuilder_Task_Id_Invalid = 1003,
        JobBuilder_Parent_Task_Id_Invalid = 1004,
        JobBuilder_Node_Task_Id_Invalid = 1005,

        // Jobs State specific
        JobsState_Abort_All_Jobs_For_Agent_Failed = 2002,

        // Job State specific
        JobState_Job_Id_Invalid = 3002,
        JobState_Task_Id_Invalid = 3003,

        // Map specific
        Map_Map_Item_Ids_Invalid = 4008,
        Map_Timeout_Invalid = 4009,
        Map_Occupying_Mandate_Already_Set = 4010,

        // Servicing specific
        Servicing_Outstanding_Requests_Get_Failed = 5001,
        Servicing_Service_Complete_Set_Failed = 5002,

        // Agent specific
        Agent_Agents_Get_Failed = 6001,
        Agent_Agent_Data_Get_Lifetime_State_Failed = 6002,
        Agent_Agent_Lifetime_State_Set_Failed = 6003,

        // Fleet Manager Specific
        Set_Frozen_State_Failed = 7002,
        Get_Kingpin_Description_Failed = 7008,
        Create_Virtual_Vehicle_Failed = 7009,
        Remove_Vehicle_Failed = 7010,
        Set_Pose_Failed = 7011,
        Reset_Kingpin_Failed = 7012,
        Set_Fleet_State_Failed = 7018,
        Set_Kingpin_State_Failed = 7019   
    }
}