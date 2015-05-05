package it.bankadati.mib.fileopener;

import java.io.IOException;
import java.net.URLConnection;
import org.apache.cordova.CallbackContext;
import org.json.JSONArray;
import org.json.JSONException;
import android.content.Intent;
import android.net.Uri;
import org.apache.cordova.CordovaPlugin;

//TODO: da implementare!!!

public class MibFileOpener extends CordovaPlugin {

    @Override
    public boolean execute(String action, JSONArray args, CallbackContext callbackContext) throws JSONException {

        // try {
            // if (action.equals("openFile")) {
                // openFile(args.getString(0));
                // callbackContext.success();
                // return true;
            // }
        // } catch (IOException e) {
            // e.printStackTrace();
            // callbackContext.error(e.getMessage());
        // } catch (RuntimeException e) {  // Activity Not Found
            // e.printStackTrace();
            // callbackContext.error(e.getMessage());
        // }
        return false;
    }

    private void openFile(String fileUrl) throws IOException {
        // // Create URI
        // Uri uri = Uri.parse(fileUrl);

        // Intent intent;
        // if (fileUrl.contains(".doc") || fileUrl.contains(".docx")) {
            // intent = new Intent(Intent.ACTION_VIEW);
            // intent.setDataAndType(uri, "application/msword");
        // } else if(fileUrl.contains(".pdf")) {
            // intent = new Intent(Intent.ACTION_VIEW);
            // intent.setDataAndType(uri, "application/pdf");
        // } else if(fileUrl.contains(".ppt") || fileUrl.contains(".pptx")) {
            // intent = new Intent(Intent.ACTION_VIEW);
            // intent.setDataAndType(uri, "application/vnd.ms-powerpoint");
        // } else if(fileUrl.contains(".xls") || fileUrl.contains(".xlsx")) {
            // intent = new Intent(Intent.ACTION_VIEW);
            // intent.setDataAndType(uri, "application/vnd.ms-excel");
        // } else if(fileUrl.contains(".rtf")) {
            // intent = new Intent(Intent.ACTION_VIEW);
            // intent.setDataAndType(uri, "application/rtf");
        // } else if(fileUrl.contains(".wav")) {
            // intent = new Intent(Intent.ACTION_VIEW);
            // intent.setDataAndType(uri, "audio/x-wav");
        // } else if(fileUrl.contains(".gif")) {
            // intent = new Intent(Intent.ACTION_VIEW);
            // intent.setDataAndType(uri, "image/gif");
        // } else if(fileUrl.contains(".jpg") || fileUrl.contains(".jpeg")) {
            // intent = new Intent(Intent.ACTION_VIEW);
            // intent.setDataAndType(uri, "image/jpeg");
        // } else if(fileUrl.contains(".txt")) {
            // intent = new Intent(Intent.ACTION_VIEW);
            // intent.setDataAndType(uri, "text/plain");
        // } else if(fileUrl.contains(".mpg") || fileUrl.contains(".mpeg") || fileUrl.contains(".mpe") || fileUrl.contains(".mp4") || fileUrl.contains(".avi")) {
            // intent = new Intent(Intent.ACTION_VIEW);
            // intent.setDataAndType(uri, "video/*");
        // }
		// //Per aprire il prompt di sistema e selezionare quale con quale app aprire
        // // else {
        // //     intent = new Intent(Intent.ACTION_VIEW);
        // //     intent.setDataAndType(uri, "*/*");
        // // }

        // else {
            // String mimeType = URLConnection.guessContentTypeFromName(fileUrl);	//In base al nome recupero il content type
            // intent = new Intent(Intent.ACTION_VIEW);
            // intent.setDataAndType(uri, mimeType);
        // }
        // Intent fileChooser = Intent.createChooser(intent, "Apri file");
		// // TODO handle ActivityNotFoundException
        // this.cordova.getActivity().startActivity(fileChooser);
    }

}