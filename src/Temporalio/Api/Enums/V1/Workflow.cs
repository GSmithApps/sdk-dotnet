// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: temporal/api/enums/v1/workflow.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021, 8981
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace Temporalio.Api.Enums.V1 {

  /// <summary>Holder for reflection information generated from temporal/api/enums/v1/workflow.proto</summary>
  public static partial class WorkflowReflection {

    #region Descriptor
    /// <summary>File descriptor for temporal/api/enums/v1/workflow.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static WorkflowReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "CiR0ZW1wb3JhbC9hcGkvZW51bXMvdjEvd29ya2Zsb3cucHJvdG8SFXRlbXBv",
            "cmFsLmFwaS5lbnVtcy52MSqLAgoVV29ya2Zsb3dJZFJldXNlUG9saWN5EigK",
            "JFdPUktGTE9XX0lEX1JFVVNFX1BPTElDWV9VTlNQRUNJRklFRBAAEiwKKFdP",
            "UktGTE9XX0lEX1JFVVNFX1BPTElDWV9BTExPV19EVVBMSUNBVEUQARI4CjRX",
            "T1JLRkxPV19JRF9SRVVTRV9QT0xJQ1lfQUxMT1dfRFVQTElDQVRFX0ZBSUxF",
            "RF9PTkxZEAISLQopV09SS0ZMT1dfSURfUkVVU0VfUE9MSUNZX1JFSkVDVF9E",
            "VVBMSUNBVEUQAxIxCi1XT1JLRkxPV19JRF9SRVVTRV9QT0xJQ1lfVEVSTUlO",
            "QVRFX0lGX1JVTk5JTkcQBCrPAQoYV29ya2Zsb3dJZENvbmZsaWN0UG9saWN5",
            "EisKJ1dPUktGTE9XX0lEX0NPTkZMSUNUX1BPTElDWV9VTlNQRUNJRklFRBAA",
            "EiQKIFdPUktGTE9XX0lEX0NPTkZMSUNUX1BPTElDWV9GQUlMEAESLAooV09S",
            "S0ZMT1dfSURfQ09ORkxJQ1RfUE9MSUNZX1VTRV9FWElTVElORxACEjIKLldP",
            "UktGTE9XX0lEX0NPTkZMSUNUX1BPTElDWV9URVJNSU5BVEVfRVhJU1RJTkcQ",
            "AyqkAQoRUGFyZW50Q2xvc2VQb2xpY3kSIwofUEFSRU5UX0NMT1NFX1BPTElD",
            "WV9VTlNQRUNJRklFRBAAEiEKHVBBUkVOVF9DTE9TRV9QT0xJQ1lfVEVSTUlO",
            "QVRFEAESHwobUEFSRU5UX0NMT1NFX1BPTElDWV9BQkFORE9OEAISJgoiUEFS",
            "RU5UX0NMT1NFX1BPTElDWV9SRVFVRVNUX0NBTkNFTBADKr0BChZDb250aW51",
            "ZUFzTmV3SW5pdGlhdG9yEikKJUNPTlRJTlVFX0FTX05FV19JTklUSUFUT1Jf",
            "VU5TUEVDSUZJRUQQABImCiJDT05USU5VRV9BU19ORVdfSU5JVElBVE9SX1dP",
            "UktGTE9XEAESIwofQ09OVElOVUVfQVNfTkVXX0lOSVRJQVRPUl9SRVRSWRAC",
            "EisKJ0NPTlRJTlVFX0FTX05FV19JTklUSUFUT1JfQ1JPTl9TQ0hFRFVMRRAD",
            "KuUCChdXb3JrZmxvd0V4ZWN1dGlvblN0YXR1cxIpCiVXT1JLRkxPV19FWEVD",
            "VVRJT05fU1RBVFVTX1VOU1BFQ0lGSUVEEAASJQohV09SS0ZMT1dfRVhFQ1VU",
            "SU9OX1NUQVRVU19SVU5OSU5HEAESJwojV09SS0ZMT1dfRVhFQ1VUSU9OX1NU",
            "QVRVU19DT01QTEVURUQQAhIkCiBXT1JLRkxPV19FWEVDVVRJT05fU1RBVFVT",
            "X0ZBSUxFRBADEiYKIldPUktGTE9XX0VYRUNVVElPTl9TVEFUVVNfQ0FOQ0VM",
            "RUQQBBIoCiRXT1JLRkxPV19FWEVDVVRJT05fU1RBVFVTX1RFUk1JTkFURUQQ",
            "BRIuCipXT1JLRkxPV19FWEVDVVRJT05fU1RBVFVTX0NPTlRJTlVFRF9BU19O",
            "RVcQBhInCiNXT1JLRkxPV19FWEVDVVRJT05fU1RBVFVTX1RJTUVEX09VVBAH",
            "KrUBChRQZW5kaW5nQWN0aXZpdHlTdGF0ZRImCiJQRU5ESU5HX0FDVElWSVRZ",
            "X1NUQVRFX1VOU1BFQ0lGSUVEEAASJAogUEVORElOR19BQ1RJVklUWV9TVEFU",
            "RV9TQ0hFRFVMRUQQARIiCh5QRU5ESU5HX0FDVElWSVRZX1NUQVRFX1NUQVJU",
            "RUQQAhIrCidQRU5ESU5HX0FDVElWSVRZX1NUQVRFX0NBTkNFTF9SRVFVRVNU",
            "RUQQAyqbAQoYUGVuZGluZ1dvcmtmbG93VGFza1N0YXRlEisKJ1BFTkRJTkdf",
            "V09SS0ZMT1dfVEFTS19TVEFURV9VTlNQRUNJRklFRBAAEikKJVBFTkRJTkdf",
            "V09SS0ZMT1dfVEFTS19TVEFURV9TQ0hFRFVMRUQQARInCiNQRU5ESU5HX1dP",
            "UktGTE9XX1RBU0tfU1RBVEVfU1RBUlRFRBACKpcBChZIaXN0b3J5RXZlbnRG",
            "aWx0ZXJUeXBlEikKJUhJU1RPUllfRVZFTlRfRklMVEVSX1RZUEVfVU5TUEVD",
            "SUZJRUQQABInCiNISVNUT1JZX0VWRU5UX0ZJTFRFUl9UWVBFX0FMTF9FVkVO",
            "VBABEikKJUhJU1RPUllfRVZFTlRfRklMVEVSX1RZUEVfQ0xPU0VfRVZFTlQQ",
            "AiqfAgoKUmV0cnlTdGF0ZRIbChdSRVRSWV9TVEFURV9VTlNQRUNJRklFRBAA",
            "EhsKF1JFVFJZX1NUQVRFX0lOX1BST0dSRVNTEAESJQohUkVUUllfU1RBVEVf",
            "Tk9OX1JFVFJZQUJMRV9GQUlMVVJFEAISFwoTUkVUUllfU1RBVEVfVElNRU9V",
            "VBADEigKJFJFVFJZX1NUQVRFX01BWElNVU1fQVRURU1QVFNfUkVBQ0hFRBAE",
            "EiQKIFJFVFJZX1NUQVRFX1JFVFJZX1BPTElDWV9OT1RfU0VUEAUSJQohUkVU",
            "UllfU1RBVEVfSU5URVJOQUxfU0VSVkVSX0VSUk9SEAYSIAocUkVUUllfU1RB",
            "VEVfQ0FOQ0VMX1JFUVVFU1RFRBAHKrABCgtUaW1lb3V0VHlwZRIcChhUSU1F",
            "T1VUX1RZUEVfVU5TUEVDSUZJRUQQABIfChtUSU1FT1VUX1RZUEVfU1RBUlRf",
            "VE9fQ0xPU0UQARIiCh5USU1FT1VUX1RZUEVfU0NIRURVTEVfVE9fU1RBUlQQ",
            "AhIiCh5USU1FT1VUX1RZUEVfU0NIRURVTEVfVE9fQ0xPU0UQAxIaChZUSU1F",
            "T1VUX1RZUEVfSEVBUlRCRUFUEAQqfwoSVmVyc2lvbmluZ0JlaGF2aW9yEiMK",
            "H1ZFUlNJT05JTkdfQkVIQVZJT1JfVU5TUEVDSUZJRUQQABIeChpWRVJTSU9O",
            "SU5HX0JFSEFWSU9SX1BJTk5FRBABEiQKIFZFUlNJT05JTkdfQkVIQVZJT1Jf",
            "QVVUT19VUEdSQURFEAJChQEKGGlvLnRlbXBvcmFsLmFwaS5lbnVtcy52MUIN",
            "V29ya2Zsb3dQcm90b1ABWiFnby50ZW1wb3JhbC5pby9hcGkvZW51bXMvdjE7",
            "ZW51bXOqAhdUZW1wb3JhbGlvLkFwaS5FbnVtcy5WMeoCGlRlbXBvcmFsaW86",
            "OkFwaTo6RW51bXM6OlYxYgZwcm90bzM="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { },
          new pbr::GeneratedClrTypeInfo(new[] {typeof(global::Temporalio.Api.Enums.V1.WorkflowIdReusePolicy), typeof(global::Temporalio.Api.Enums.V1.WorkflowIdConflictPolicy), typeof(global::Temporalio.Api.Enums.V1.ParentClosePolicy), typeof(global::Temporalio.Api.Enums.V1.ContinueAsNewInitiator), typeof(global::Temporalio.Api.Enums.V1.WorkflowExecutionStatus), typeof(global::Temporalio.Api.Enums.V1.PendingActivityState), typeof(global::Temporalio.Api.Enums.V1.PendingWorkflowTaskState), typeof(global::Temporalio.Api.Enums.V1.HistoryEventFilterType), typeof(global::Temporalio.Api.Enums.V1.RetryState), typeof(global::Temporalio.Api.Enums.V1.TimeoutType), typeof(global::Temporalio.Api.Enums.V1.VersioningBehavior), }, null, null));
    }
    #endregion

  }
  #region Enums
  /// <summary>
  /// Defines whether to allow re-using a workflow id from a previously *closed* workflow.
  /// If the request is denied, the server returns a `WorkflowExecutionAlreadyStartedFailure` error.
  ///
  /// See `WorkflowIdConflictPolicy` for handling workflow id duplication with a *running* workflow.
  /// </summary>
  public enum WorkflowIdReusePolicy {
    [pbr::OriginalName("WORKFLOW_ID_REUSE_POLICY_UNSPECIFIED")] Unspecified = 0,
    /// <summary>
    /// Allow starting a workflow execution using the same workflow id.
    /// </summary>
    [pbr::OriginalName("WORKFLOW_ID_REUSE_POLICY_ALLOW_DUPLICATE")] AllowDuplicate = 1,
    /// <summary>
    /// Allow starting a workflow execution using the same workflow id, only when the last
    /// execution's final state is one of [terminated, cancelled, timed out, failed].
    /// </summary>
    [pbr::OriginalName("WORKFLOW_ID_REUSE_POLICY_ALLOW_DUPLICATE_FAILED_ONLY")] AllowDuplicateFailedOnly = 2,
    /// <summary>
    /// Do not permit re-use of the workflow id for this workflow. Future start workflow requests
    /// could potentially change the policy, allowing re-use of the workflow id.
    /// </summary>
    [pbr::OriginalName("WORKFLOW_ID_REUSE_POLICY_REJECT_DUPLICATE")] RejectDuplicate = 3,
    /// <summary>
    /// This option belongs in WorkflowIdConflictPolicy but is here for backwards compatibility.
    /// If specified, it acts like ALLOW_DUPLICATE, but also the WorkflowId*Conflict*Policy on
    /// the request is treated as WORKFLOW_ID_CONFLICT_POLICY_TERMINATE_EXISTING.
    /// If no running workflow, then the behavior is the same as ALLOW_DUPLICATE.
    /// </summary>
    [pbr::OriginalName("WORKFLOW_ID_REUSE_POLICY_TERMINATE_IF_RUNNING")] TerminateIfRunning = 4,
  }

  /// <summary>
  /// Defines what to do when trying to start a workflow with the same workflow id as a *running* workflow.
  /// Note that it is *never* valid to have two actively running instances of the same workflow id.
  ///
  /// See `WorkflowIdReusePolicy` for handling workflow id duplication with a *closed* workflow.
  /// </summary>
  public enum WorkflowIdConflictPolicy {
    [pbr::OriginalName("WORKFLOW_ID_CONFLICT_POLICY_UNSPECIFIED")] Unspecified = 0,
    /// <summary>
    /// Don't start a new workflow; instead return `WorkflowExecutionAlreadyStartedFailure`.
    /// </summary>
    [pbr::OriginalName("WORKFLOW_ID_CONFLICT_POLICY_FAIL")] Fail = 1,
    /// <summary>
    /// Don't start a new workflow; instead return a workflow handle for the running workflow.
    /// </summary>
    [pbr::OriginalName("WORKFLOW_ID_CONFLICT_POLICY_USE_EXISTING")] UseExisting = 2,
    /// <summary>
    /// Terminate the running workflow before starting a new one.
    /// </summary>
    [pbr::OriginalName("WORKFLOW_ID_CONFLICT_POLICY_TERMINATE_EXISTING")] TerminateExisting = 3,
  }

  /// <summary>
  /// Defines how child workflows will react to their parent completing
  /// </summary>
  public enum ParentClosePolicy {
    [pbr::OriginalName("PARENT_CLOSE_POLICY_UNSPECIFIED")] Unspecified = 0,
    /// <summary>
    /// The child workflow will also terminate
    /// </summary>
    [pbr::OriginalName("PARENT_CLOSE_POLICY_TERMINATE")] Terminate = 1,
    /// <summary>
    /// The child workflow will do nothing
    /// </summary>
    [pbr::OriginalName("PARENT_CLOSE_POLICY_ABANDON")] Abandon = 2,
    /// <summary>
    /// Cancellation will be requested of the child workflow
    /// </summary>
    [pbr::OriginalName("PARENT_CLOSE_POLICY_REQUEST_CANCEL")] RequestCancel = 3,
  }

  public enum ContinueAsNewInitiator {
    [pbr::OriginalName("CONTINUE_AS_NEW_INITIATOR_UNSPECIFIED")] Unspecified = 0,
    /// <summary>
    /// The workflow itself requested to continue as new
    /// </summary>
    [pbr::OriginalName("CONTINUE_AS_NEW_INITIATOR_WORKFLOW")] Workflow = 1,
    /// <summary>
    /// The workflow continued as new because it is retrying
    /// </summary>
    [pbr::OriginalName("CONTINUE_AS_NEW_INITIATOR_RETRY")] Retry = 2,
    /// <summary>
    /// The workflow continued as new because cron has triggered a new execution
    /// </summary>
    [pbr::OriginalName("CONTINUE_AS_NEW_INITIATOR_CRON_SCHEDULE")] CronSchedule = 3,
  }

  /// <summary>
  /// (-- api-linter: core::0216::synonyms=disabled
  ///     aip.dev/not-precedent: There is WorkflowExecutionState already in another package. --)
  /// </summary>
  public enum WorkflowExecutionStatus {
    [pbr::OriginalName("WORKFLOW_EXECUTION_STATUS_UNSPECIFIED")] Unspecified = 0,
    /// <summary>
    /// Value 1 is hardcoded in SQL persistence.
    /// </summary>
    [pbr::OriginalName("WORKFLOW_EXECUTION_STATUS_RUNNING")] Running = 1,
    [pbr::OriginalName("WORKFLOW_EXECUTION_STATUS_COMPLETED")] Completed = 2,
    [pbr::OriginalName("WORKFLOW_EXECUTION_STATUS_FAILED")] Failed = 3,
    [pbr::OriginalName("WORKFLOW_EXECUTION_STATUS_CANCELED")] Canceled = 4,
    [pbr::OriginalName("WORKFLOW_EXECUTION_STATUS_TERMINATED")] Terminated = 5,
    [pbr::OriginalName("WORKFLOW_EXECUTION_STATUS_CONTINUED_AS_NEW")] ContinuedAsNew = 6,
    [pbr::OriginalName("WORKFLOW_EXECUTION_STATUS_TIMED_OUT")] TimedOut = 7,
  }

  public enum PendingActivityState {
    [pbr::OriginalName("PENDING_ACTIVITY_STATE_UNSPECIFIED")] Unspecified = 0,
    [pbr::OriginalName("PENDING_ACTIVITY_STATE_SCHEDULED")] Scheduled = 1,
    [pbr::OriginalName("PENDING_ACTIVITY_STATE_STARTED")] Started = 2,
    [pbr::OriginalName("PENDING_ACTIVITY_STATE_CANCEL_REQUESTED")] CancelRequested = 3,
  }

  public enum PendingWorkflowTaskState {
    [pbr::OriginalName("PENDING_WORKFLOW_TASK_STATE_UNSPECIFIED")] Unspecified = 0,
    [pbr::OriginalName("PENDING_WORKFLOW_TASK_STATE_SCHEDULED")] Scheduled = 1,
    [pbr::OriginalName("PENDING_WORKFLOW_TASK_STATE_STARTED")] Started = 2,
  }

  public enum HistoryEventFilterType {
    [pbr::OriginalName("HISTORY_EVENT_FILTER_TYPE_UNSPECIFIED")] Unspecified = 0,
    [pbr::OriginalName("HISTORY_EVENT_FILTER_TYPE_ALL_EVENT")] AllEvent = 1,
    [pbr::OriginalName("HISTORY_EVENT_FILTER_TYPE_CLOSE_EVENT")] CloseEvent = 2,
  }

  public enum RetryState {
    [pbr::OriginalName("RETRY_STATE_UNSPECIFIED")] Unspecified = 0,
    [pbr::OriginalName("RETRY_STATE_IN_PROGRESS")] InProgress = 1,
    [pbr::OriginalName("RETRY_STATE_NON_RETRYABLE_FAILURE")] NonRetryableFailure = 2,
    [pbr::OriginalName("RETRY_STATE_TIMEOUT")] Timeout = 3,
    [pbr::OriginalName("RETRY_STATE_MAXIMUM_ATTEMPTS_REACHED")] MaximumAttemptsReached = 4,
    [pbr::OriginalName("RETRY_STATE_RETRY_POLICY_NOT_SET")] RetryPolicyNotSet = 5,
    [pbr::OriginalName("RETRY_STATE_INTERNAL_SERVER_ERROR")] InternalServerError = 6,
    [pbr::OriginalName("RETRY_STATE_CANCEL_REQUESTED")] CancelRequested = 7,
  }

  public enum TimeoutType {
    [pbr::OriginalName("TIMEOUT_TYPE_UNSPECIFIED")] Unspecified = 0,
    [pbr::OriginalName("TIMEOUT_TYPE_START_TO_CLOSE")] StartToClose = 1,
    [pbr::OriginalName("TIMEOUT_TYPE_SCHEDULE_TO_START")] ScheduleToStart = 2,
    [pbr::OriginalName("TIMEOUT_TYPE_SCHEDULE_TO_CLOSE")] ScheduleToClose = 3,
    [pbr::OriginalName("TIMEOUT_TYPE_HEARTBEAT")] Heartbeat = 4,
  }

  /// <summary>
  /// Versioning Behavior specifies if and how a workflow execution moves between Worker Deployment
  /// Versions. The Versioning Behavior of a workflow execution is typically specified by the worker
  /// who completes the first task of the execution, but is also overridable manually for new and
  /// existing workflows (see VersioningOverride).
  /// Experimental. Worker Deployments are experimental and might significantly change in the future.
  /// </summary>
  public enum VersioningBehavior {
    /// <summary>
    /// Workflow execution does not have a Versioning Behavior and is called Unversioned. This is the
    /// legacy behavior. An Unversioned workflow's task can go to any Unversioned worker (see
    /// `WorkerVersioningMode`.)
    /// User needs to use Patching to keep the new code compatible with prior versions when dealing
    /// with Unversioned workflows.
    /// </summary>
    [pbr::OriginalName("VERSIONING_BEHAVIOR_UNSPECIFIED")] Unspecified = 0,
    /// <summary>
    /// Workflow will start on the Current Deployment Version of its Task Queue, and then
    /// will be pinned to that same Deployment Version until completion (the Version that
    /// this Workflow is pinned to is specified in `versioning_info.version`).
    /// This behavior eliminates most of compatibility concerns users face when changing their code.
    /// Patching is not needed when pinned workflows code change.
    /// Can be overridden explicitly via `UpdateWorkflowExecutionOptions` API to move the
    /// execution to another Deployment Version.
    /// Activities of `PINNED` workflows are sent to the same Deployment Version. Exception to this
    /// would be when the activity Task Queue workers are not present in the workflow's Deployment
    /// Version, in which case the activity will be sent to the Current Deployment Version of its own
    /// task queue.
    /// </summary>
    [pbr::OriginalName("VERSIONING_BEHAVIOR_PINNED")] Pinned = 1,
    /// <summary>
    /// Workflow will automatically move to the Current Deployment Version of its Task Queue when the
    /// next workflow task is dispatched.
    /// AutoUpgrade behavior is suitable for long-running workflows as it allows them to move to the
    /// latest Deployment Version, but the user still needs to use Patching to keep the new code
    /// compatible with prior versions for changed workflow types.
    /// Activities of `AUTO_UPGRADE` workflows are sent to the Deployment Version of the workflow
    /// execution (as specified in versioning_info.version based on the last completed
    /// workflow task). Exception to this would be when the activity Task Queue workers are not
    /// present in the workflow's Deployment Version, in which case, the activity will be sent to a
    /// different Deployment Version according to the Current Deployment Version of its own task
    /// queue.
    /// Workflows stuck on a backlogged activity will still auto-upgrade if the Current Deployment
    /// Version of their Task Queue changes, without having to wait for the backlogged activity to
    /// complete on the old Version.
    /// </summary>
    [pbr::OriginalName("VERSIONING_BEHAVIOR_AUTO_UPGRADE")] AutoUpgrade = 2,
  }

  #endregion

}

#endregion Designer generated code
