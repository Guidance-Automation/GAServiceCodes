namespace GAServiceCodes.Architecture;

public enum ErrorCode
{
    //////////////////////////
    // Job Builder specific //
    //////////////////////////

    // Generic
    JobBuilder_Job_Id_Invalid = 1000,
    JobBuilder_Task_Id_Invalid = 1001,
    JobBuilder_Parent_Task_Id_Invalid = 1002,
    JobBuilder_Node_Task_Id_Invalid = 1003,
    JobBuilder_JobRepository_Not_Accepting_Jobs = 1004,
    JobBuilder_Job_Invalid = 1005,


    // Failed Calls
    JobBuilder_Job_Id_Commit_Failed = 1100,
    JobBuilder_Commit_Job_Failed = 1101,
    JobBuilder_Create_GoTo_Node_Task_Failed = 1102,
    JobBuilder_Create_Atomic_Move_Task_Failed = 1103,
    JobBuilder_Create_Awaiting_Task_Failed = 1104,
    JobBuilder_Create_Ordered_ListTask_Failed = 1105,
    JobBuilder_Create_Servicing_Task_Failed = 1106,
    JobBuilder_Create_Atomic_Move_ListTask_Failed = 1107,
    JobBuilder_Begin_Editing_Task_Failed = 1108,
    JobBuilder_Create_Charge_Task_Failed = 1109,

    JobBuilder_Create_Sleeping_Task_Failed = 1110,
    JobBuilder_Finish_Editing_Task_Failed = 1111,
    JobBuilder_Issue_Enum_Directive_failed = 1112,
    JobBuilder_Create_Unordered_ListTask_Failed = 1113,
    JobBuilder_Finish_Editing_Job_Failed = 1114,
    JobBuilder_Issue_Float_Directive_Failed = 1115,
    JobBuilder_Issue_IPAddress_Directive_Failed = 1116,
    JobBuilder_Issue_Short_Directive_Failed = 1117,
    JobBuilder_Issue_UShort_Directive_Failed = 1118,
    JobBuilder_Create_Job_Failed = 1119,

    /////////////////////////
    // Jobs State specific //
    /////////////////////////

    // Generic
    JobsState_Task_Id_Invalid = 2000,
    JobsState_Job_Id_Invalid = 2001,

    // Failed Calls
    JobsState_Abort_All_Jobs_For_Agent_Failed = 2100,
    JobsState_Get_Active_Job_Ids_For_Agent_Failed = 2101,
    JobsState_Abort_Task_Failed = 2102,
    JobsState_Abort_Job_Failed = 2103,

    ////////////////////////
    // Job State specific //
    ////////////////////////

    // Generic
    JobState_Job_Id_Invalid = 3002,
    JobState_Task_Id_Invalid = 3003,


    // Failed Calls 
    JobState_Get_Current_Job_Summary_For_AgentId_Failed = 3100,
    JobState_Get_Job_Summary_Failed = 3101,
    JobState_Get_Parent_Job_Summary_From_TaskId_Failed = 3102,

    //////////////////
    // Map specific //
    //////////////////

    // Generic
    Map_Map_Item_Ids_Invalid = 4000,
    Map_Timeout_Invalid = 4001,
    Map_Occupying_Mandate_Already_Set = 4002,

    // Failed
    Map_Set_OccupyingMandate_Failed = 4100,
    Map_ClearOccupyingMandate_Failed = 41001,
    Map_Get_All_Parameter_Data_Failed = 41002,
    Map_Get_All_Move_Data_Failed = 41003,
    Map_Get_All_Node_Data_Failed = 41004,
    Map_Get_Occupying_Mandate_Progress_Data_Failed = 41005,
    Map_Get_Trajectory_Failed = 41006,


    ////////////////////////
    // Servicing specific //
    ////////////////////////

    // Generic

    // Failed Calls
    Servicing_Outstanding_Requests_Get_Failed = 5100,
    Servicing_Service_Complete_Set_Failed = 5101,

    ////////////////////
    // Agent specific // 
    ////////////////////

    // Generic

    // Failed Calls
    Agent_Agents_Get_Failed = 6100,
    Agent_Agent_Data_Get_Lifetime_State_Failed = 6101,
    Agent_Agent_Lifetime_State_Set_Failed = 6102,

    ////////////////////////////
    // Fleet Manager Specific //
    ////////////////////////////

    // Generic

    // Failed Calls
    FleetManager_Set_Frozen_State_Failed = 7100,
    FleetManager_Get_Kingpin_Description_Failed = 7101,
    FleetManager_Create_Virtual_Vehicle_Failed = 7102,
    FleetManager_Remove_Vehicle_Failed = 7103,
    FleetManager_Set_Pose_Failed = 7104,
    FleetManager_Reset_Kingpin_Failed = 7105,
    FleetManager_Set_Fleet_State_Failed = 7106,
    FleetManager_Set_Kingpin_State_Failed = 7107,
    FleetManager_Commit_Waypoints_Failed = 7108,
    FleetManager_Get_Vehicle_Limit_Failed = 7109,
    FleetManager_Agent_Does_Not_Exist = 7110
}