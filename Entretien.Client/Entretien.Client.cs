namespace Entretien.Client {
    
    
    public partial class EntretienSyncAgent {
        
        partial void OnInitialized(){
            Client.SyncDirection = Microsoft.Synchronization.Data.SyncDirection.Bidirectional;
        }
    }
}
