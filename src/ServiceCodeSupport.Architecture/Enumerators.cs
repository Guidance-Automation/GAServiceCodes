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
        JobBuilder_JobRepository_Not_Accepting_Jobs = 1007,

        JobBuilder_Create_Job_Failed = 1010,
        JobBuilder_Create_GoTo_Node_Task_Failed = 1011,
        JobBuilder_Create_Atomic_Move_Task_Failed = 1012,
        JobBuilder_Create_Awaiting_Task_Failed = 1013,
        JobBuilder_Create_Ordered_ListTask_Failed = 1014,
        JobBuilder_Create_Servicing_Task_Failed = 1015,
        JobBuilder_Create_Atomic_Move_ListTask_Failed = 1016,
        JobBuilder_Begin_Editing_Task_Failed = 1017,
        JobBuilder_Create_Charge_Task_Failed = 1018,
        JobBuilder_Create_Sleeping_Task_Failed = 1019,

        JobBuilder_Finish_Editing_Task_Failed = 1020,
        JobBuilder_Issue_Enum_Directive_failed = 1021,
        JobBuilder_Create_Unordered_ListTask_Failed = 1022,
        JobBuilder_Finish_Editing_Job_Failed = 1023,
        JobBuilder_Issue_Float_Directive_Failed = 1024,
        JobBuilder_Issue_IPAddress_Directive_Failed = 1025,
        JobBuilder_Issue_Short_Directive_Failed = 1026,
        JobBuilder_Issue_UShort_Directive_Failed = 1027,


        // Jobs State specific
        JobsState_Abort_All_Jobs_For_Agent_Failed = 2002,

        // Job State specific
        JobState_Job_Id_Invalid = 3002,
        JobState_Task_Id_Invalid = 3003,

        // Map specific
        Map_Set_OccupyingMandate_Failed = 4000,
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
        FleetManager_Set_Frozen_State_Failed = 7002,
        FleetManager_Get_Kingpin_Description_Failed = 7008,
        FleetManager_Create_Virtual_Vehicle_Failed = 7009,

        FleetManager_Remove_Vehicle_Failed = 7010,
        FleetManager_Set_Pose_Failed = 7011,
        FleetManager_Reset_Kingpin_Failed = 7012,
        FleetManager_Set_Fleet_State_Failed = 7018,
        FleetManager_Set_Kingpin_State_Failed = 7019   
    }
}