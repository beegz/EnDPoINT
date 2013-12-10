using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using ClearCanvas.Dicom.IO;
using ClearCanvas.Common;
using ClearCanvas.ImageViewer;
using ClearCanvas.ImageViewer.StudyManagement;
using ClearCanvas.Dicom;
using ClearCanvas.Dicom.Network;
using ClearCanvas.Dicom.Utilities.Statistics;
using System.Drawing;

namespace EnDPoINT
{
    /// <summary>
    /// Provides DICOM server functionality for EnDPoINT printserver
    /// </summary>
    class dcmServer : IDicomServerHandler
    {
        #region Private Members
        private static bool _running;
        private static ServerAssociationParameters _param;
        #endregion

        #region Constructors
        private dcmServer(DicomServer server, ServerAssociationParameters param)
        {
            //TODO: Add stuff
        }
        #endregion

        #region Public Properties
        public bool Running
        {
            get { return _running; }
        }

        /// <summary>
        /// Path to store recieved data
        /// </summary>
        public static string StoragePath { get; set; }

        public static bool Bitbucket { get; set; }
        public static bool List { get; set; }

        public static bool JpegLossless { get; set; }
        public static bool JpegLossy { get; set; }
        public static bool Rle { get; set; }
        public static bool J2KLossy { get; set; }
        public static bool J2KLossless { get; set; }

        #endregion

        #region Private Methods
        private static void SetImageTransferSyntaxes(byte pcid, ServerAssociationParameters assoc)
        {
            if (JpegLossless)
                assoc.AddTransferSyntax(pcid, TransferSyntax.JpegLosslessNonHierarchicalFirstOrderPredictionProcess14SelectionValue1);
            if (Rle)
                assoc.AddTransferSyntax(pcid, TransferSyntax.RleLossless);
            if (J2KLossy)
                assoc.AddTransferSyntax(pcid, TransferSyntax.Jpeg2000ImageCompression);
            if (J2KLossless)
                assoc.AddTransferSyntax(pcid, TransferSyntax.Jpeg2000ImageCompressionLosslessOnly);
            if (JpegLossy)
            {
                assoc.AddTransferSyntax(pcid, TransferSyntax.JpegBaselineProcess1);
                assoc.AddTransferSyntax(pcid, TransferSyntax.JpegExtendedProcess24);
            }
            assoc.AddTransferSyntax(pcid, TransferSyntax.ExplicitVrLittleEndian);
            assoc.AddTransferSyntax(pcid, TransferSyntax.ImplicitVrLittleEndian);
        }

        private static void AddPresentationContexts(ServerAssociationParameters assoc)
        {
            byte pcid = assoc.AddPresentationContext(SopClass.VerificationSopClass);
            assoc.AddTransferSyntax(pcid, TransferSyntax.ExplicitVrLittleEndian);
            assoc.AddTransferSyntax(pcid, TransferSyntax.ImplicitVrLittleEndian);

            pcid = assoc.AddPresentationContext(SopClass.GrayscaleSoftcopyPresentationStateStorageSopClass);
            assoc.AddTransferSyntax(pcid, TransferSyntax.ExplicitVrLittleEndian);
            assoc.AddTransferSyntax(pcid, TransferSyntax.ImplicitVrLittleEndian);

            pcid = assoc.AddPresentationContext(SopClass.KeyObjectSelectionDocumentStorage);
            assoc.AddTransferSyntax(pcid, TransferSyntax.ExplicitVrLittleEndian);
            assoc.AddTransferSyntax(pcid, TransferSyntax.ImplicitVrLittleEndian);

            pcid = assoc.AddPresentationContext(SopClass.ComprehensiveSrStorage);
            assoc.AddTransferSyntax(pcid, TransferSyntax.ExplicitVrLittleEndian);
            assoc.AddTransferSyntax(pcid, TransferSyntax.ImplicitVrLittleEndian);

            pcid = assoc.AddPresentationContext(SopClass.BlendingSoftcopyPresentationStateStorageSopClass);
            assoc.AddTransferSyntax(pcid, TransferSyntax.ExplicitVrLittleEndian);
            assoc.AddTransferSyntax(pcid, TransferSyntax.ImplicitVrLittleEndian);

            pcid = assoc.AddPresentationContext(SopClass.ColonCadSrStorage);
            assoc.AddTransferSyntax(pcid, TransferSyntax.ExplicitVrLittleEndian);
            assoc.AddTransferSyntax(pcid, TransferSyntax.ImplicitVrLittleEndian);

            pcid = assoc.AddPresentationContext(SopClass.DeformableSpatialRegistrationStorage);
            assoc.AddTransferSyntax(pcid, TransferSyntax.ExplicitVrLittleEndian);
            assoc.AddTransferSyntax(pcid, TransferSyntax.ImplicitVrLittleEndian);

            pcid = assoc.AddPresentationContext(SopClass.EnhancedSrStorage);
            assoc.AddTransferSyntax(pcid, TransferSyntax.ExplicitVrLittleEndian);
            assoc.AddTransferSyntax(pcid, TransferSyntax.ImplicitVrLittleEndian);

            pcid = assoc.AddPresentationContext(SopClass.BasicTextSrStorage);
            assoc.AddTransferSyntax(pcid, TransferSyntax.ExplicitVrLittleEndian);
            assoc.AddTransferSyntax(pcid, TransferSyntax.ImplicitVrLittleEndian);

            pcid = assoc.AddPresentationContext(SopClass.EncapsulatedPdfStorage);
            assoc.AddTransferSyntax(pcid, TransferSyntax.ExplicitVrLittleEndian);
            assoc.AddTransferSyntax(pcid, TransferSyntax.ImplicitVrLittleEndian);

            pcid = assoc.AddPresentationContext(SopClass.XRayRadiationDoseSrStorage);
            assoc.AddTransferSyntax(pcid, TransferSyntax.ExplicitVrLittleEndian);
            assoc.AddTransferSyntax(pcid, TransferSyntax.ImplicitVrLittleEndian);

            pcid = assoc.AddPresentationContext(SopClass.ChestCadSrStorage);
            assoc.AddTransferSyntax(pcid, TransferSyntax.ExplicitVrLittleEndian);
            assoc.AddTransferSyntax(pcid, TransferSyntax.ImplicitVrLittleEndian);

            pcid = assoc.AddPresentationContext(SopClass.EncapsulatedCdaStorage);
            assoc.AddTransferSyntax(pcid, TransferSyntax.ExplicitVrLittleEndian);
            assoc.AddTransferSyntax(pcid, TransferSyntax.ImplicitVrLittleEndian);

            pcid = assoc.AddPresentationContext(SopClass.MrImageStorage);
            SetImageTransferSyntaxes(pcid, assoc);

            pcid = assoc.AddPresentationContext(SopClass.CtImageStorage);
            SetImageTransferSyntaxes(pcid, assoc);

            pcid = assoc.AddPresentationContext(SopClass.SecondaryCaptureImageStorage);
            SetImageTransferSyntaxes(pcid, assoc);

            pcid = assoc.AddPresentationContext(SopClass.UltrasoundImageStorage);
            SetImageTransferSyntaxes(pcid, assoc);

            pcid = assoc.AddPresentationContext(SopClass.UltrasoundImageStorageRetired);
            SetImageTransferSyntaxes(pcid, assoc);

            pcid = assoc.AddPresentationContext(SopClass.UltrasoundMultiFrameImageStorage);
            SetImageTransferSyntaxes(pcid, assoc);

            pcid = assoc.AddPresentationContext(SopClass.UltrasoundMultiFrameImageStorageRetired);
            SetImageTransferSyntaxes(pcid, assoc);

            pcid = assoc.AddPresentationContext(SopClass.NuclearMedicineImageStorage);
            SetImageTransferSyntaxes(pcid, assoc);

            pcid = assoc.AddPresentationContext(SopClass.DigitalIntraOralXRayImageStorageForPresentation);
            SetImageTransferSyntaxes(pcid, assoc);

            pcid = assoc.AddPresentationContext(SopClass.DigitalIntraOralXRayImageStorageForProcessing);
            SetImageTransferSyntaxes(pcid, assoc);

            pcid = assoc.AddPresentationContext(SopClass.DigitalMammographyXRayImageStorageForPresentation);
            SetImageTransferSyntaxes(pcid, assoc);

            pcid = assoc.AddPresentationContext(SopClass.DigitalMammographyXRayImageStorageForProcessing);
            SetImageTransferSyntaxes(pcid, assoc);

            pcid = assoc.AddPresentationContext(SopClass.DigitalXRayImageStorageForPresentation);
            SetImageTransferSyntaxes(pcid, assoc);

            pcid = assoc.AddPresentationContext(SopClass.DigitalXRayImageStorageForProcessing);
            SetImageTransferSyntaxes(pcid, assoc);

            pcid = assoc.AddPresentationContext(SopClass.ComputedRadiographyImageStorage);
            SetImageTransferSyntaxes(pcid, assoc);

            pcid = assoc.AddPresentationContext(SopClass.OphthalmicPhotography16BitImageStorage);
            SetImageTransferSyntaxes(pcid, assoc);

            pcid = assoc.AddPresentationContext(SopClass.OphthalmicPhotography8BitImageStorage);
            SetImageTransferSyntaxes(pcid, assoc);

            pcid = assoc.AddPresentationContext(SopClass.VideoEndoscopicImageStorage);
            SetImageTransferSyntaxes(pcid, assoc);

            pcid = assoc.AddPresentationContext(SopClass.VideoMicroscopicImageStorage);
            SetImageTransferSyntaxes(pcid, assoc);

            pcid = assoc.AddPresentationContext(SopClass.VideoPhotographicImageStorage);
            SetImageTransferSyntaxes(pcid, assoc);

            pcid = assoc.AddPresentationContext(SopClass.VlEndoscopicImageStorage);
            SetImageTransferSyntaxes(pcid, assoc);

            pcid = assoc.AddPresentationContext(SopClass.VlMicroscopicImageStorage);
            SetImageTransferSyntaxes(pcid, assoc);

            pcid = assoc.AddPresentationContext(SopClass.VlPhotographicImageStorage);
            SetImageTransferSyntaxes(pcid, assoc);

            pcid = assoc.AddPresentationContext(SopClass.VlSlideCoordinatesMicroscopicImageStorage);
            SetImageTransferSyntaxes(pcid, assoc);

            pcid = assoc.AddPresentationContext(SopClass.XRayAngiographicBiPlaneImageStorageRetired);
            SetImageTransferSyntaxes(pcid, assoc);

            pcid = assoc.AddPresentationContext(SopClass.XRayAngiographicImageStorage);
            SetImageTransferSyntaxes(pcid, assoc);

            pcid = assoc.AddPresentationContext(SopClass.XRayRadiofluoroscopicImageStorage);
            SetImageTransferSyntaxes(pcid, assoc);

            pcid = assoc.AddPresentationContext(SopClass.XRay3dAngiographicImageStorage);
            SetImageTransferSyntaxes(pcid, assoc);

            pcid = assoc.AddPresentationContext(SopClass.XRay3dCraniofacialImageStorage);
            SetImageTransferSyntaxes(pcid, assoc);

            pcid = assoc.AddPresentationContext(SopClass.OphthalmicTomographyImageStorage);
            SetImageTransferSyntaxes(pcid, assoc);

            pcid = assoc.AddPresentationContext(SopClass.EnhancedCtImageStorage);
            SetImageTransferSyntaxes(pcid, assoc);

            pcid = assoc.AddPresentationContext(SopClass.EnhancedMrColorImageStorage);
            SetImageTransferSyntaxes(pcid, assoc);

            pcid = assoc.AddPresentationContext(SopClass.EnhancedMrImageStorage);
            SetImageTransferSyntaxes(pcid, assoc);

            pcid = assoc.AddPresentationContext(SopClass.EnhancedPetImageStorage);
            SetImageTransferSyntaxes(pcid, assoc);

            pcid = assoc.AddPresentationContext(SopClass.BreastTomosynthesisImageStorage);
            SetImageTransferSyntaxes(pcid, assoc);

            pcid = assoc.AddPresentationContext(SopClass.EnhancedUsVolumeStorage);
            SetImageTransferSyntaxes(pcid, assoc);

        }
        #endregion

        #region Static Public Methods
        public static void StartListening(string aeTitle, IPAddress ip, int port)
        {
            if (_running)
                return;

            _param = new ServerAssociationParameters(aeTitle, new IPEndPoint(ip, port));

            AddPresentationContexts(_param);

            DicomServer.StartListening(_param,
                                       (server, assoc) => new dcmServer(server, assoc));

            _running = true;
        }

        public static void StopListening(int port)
        {
            if (_running)
            {
                DicomServer.StopListening(_param);
                _running = false;
            }
        }
        #endregion

        #region IDicomServerHandler Members


        void IDicomServerHandler.OnReceiveAssociateRequest(DicomServer server, ServerAssociationParameters association)
        {
            server.SendAssociateAccept(association);
        }

        void IDicomServerHandler.OnReceiveRequestMessage(DicomServer server, ServerAssociationParameters association, byte presentationID, DicomMessage message)
        {

            if (message.CommandField == DicomCommandField.CEchoRequest)
            {
                server.SendCEchoResponse(presentationID, message.MessageId, DicomStatuses.Success);
                return;
            }

            String studyInstanceUid = null;
            String seriesInstanceUid = null;
            DicomUid sopInstanceUid;
            String patientName = null;

            bool ok = message.DataSet[DicomTags.SopInstanceUid].TryGetUid(0, out sopInstanceUid);
            if (ok) ok = message.DataSet[DicomTags.SeriesInstanceUid].TryGetString(0, out seriesInstanceUid);
            if (ok) ok = message.DataSet[DicomTags.StudyInstanceUid].TryGetString(0, out studyInstanceUid);
            if (ok) ok = message.DataSet[DicomTags.PatientsName].TryGetString(0, out patientName);

            if (!ok)
            {
                Platform.Log(LogLevel.Error, "Unable to retrieve UIDs from request message, sending failure status.");

                server.SendCStoreResponse(presentationID, message.MessageId, sopInstanceUid.UID,
                    DicomStatuses.ProcessingFailure);
                return;
            }
            TransferSyntax syntax = association.GetPresentationContext(presentationID).AcceptedTransferSyntax;

            if (List)
            {
                Platform.Log(LogLevel.Info, message.Dump());
            }

            if (Bitbucket)
            {
                Platform.Log(LogLevel.Info, "Received SOP Instance: {0} for patient {1} in syntax {2}", sopInstanceUid,
                             patientName, syntax.Name);

                server.SendCStoreResponse(presentationID, message.MessageId,
                    sopInstanceUid.UID,
                    DicomStatuses.Success);
                return;
            }

            if (!Directory.Exists(StoragePath))
                Directory.CreateDirectory(StoragePath);

            var path = new StringBuilder();
            path.AppendFormat("{0}{1}{2}{3}{4}", StoragePath, Path.DirectorySeparatorChar,
                studyInstanceUid, Path.DirectorySeparatorChar, seriesInstanceUid);

            Directory.CreateDirectory(path.ToString());

            path.AppendFormat("{0}{1}.dcm", Path.DirectorySeparatorChar, sopInstanceUid.UID);

            var dicomFile = new DicomFile(message, path.ToString())
            {
                TransferSyntaxUid = syntax.UidString,
                MediaStorageSopInstanceUid = sopInstanceUid.UID,
                ImplementationClassUid = DicomImplementation.ClassUID.UID,
                ImplementationVersionName = DicomImplementation.Version,
                SourceApplicationEntityTitle = association.CallingAE,
                MediaStorageSopClassUid = message.SopClass.Uid
            };


            dicomFile.Save(DicomWriteOptions.None);

            Platform.Log(LogLevel.Info, "Received SOP Instance: {0} for patient {1} in syntax {2}", sopInstanceUid, patientName, syntax.Name);

            server.SendCStoreResponse(presentationID, message.MessageId,
                sopInstanceUid.UID,
                DicomStatuses.Success);
        }

        void IDicomServerHandler.OnReceiveResponseMessage(DicomServer server, ServerAssociationParameters association, byte presentationID, DicomMessage message)
        {
            Platform.Log(LogLevel.Error, "Unexpectedly received response mess on server.");

            server.SendAssociateAbort(DicomAbortSource.ServiceUser, DicomAbortReason.UnrecognizedPDU);
        }



        void IDicomServerHandler.OnReceiveReleaseRequest(DicomServer server, ServerAssociationParameters association)
        {
            Platform.Log(LogLevel.Info, "Received association release request from  {0}.", association.CallingAE);
        }

        public void OnReceiveDimseCommand(DicomServer server, ServerAssociationParameters association, byte presentationId,DicomAttributeCollection command)
        {
        }

        public IDicomFilestreamHandler OnStartFilestream(DicomServer server, ServerAssociationParameters association,
                                                         byte presentationId, DicomMessage message)
        {
            // Should not be called bcause OnReceiveDimseCommand isn't doing anything
            throw new NotImplementedException();
        }

        void IDicomServerHandler.OnReceiveAbort(DicomServer server, ServerAssociationParameters association, DicomAbortSource source, DicomAbortReason reason)
        {
            Platform.Log(LogLevel.Error, "Unexpected association abort received.");
        }

        void IDicomServerHandler.OnNetworkError(DicomServer server, ServerAssociationParameters association, Exception e)
        {
            Platform.Log(LogLevel.Error, e, "Unexpected network error over association from {0}.", association.CallingAE);
        }

        void IDicomServerHandler.OnDimseTimeout(DicomServer server, ServerAssociationParameters association)
        {
            Platform.Log(LogLevel.Info, "Received DIMSE Timeout, continuing listening for messages");
        }

        #endregion

    }
}
