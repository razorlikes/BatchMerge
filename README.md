# BatchMerge - Batch MKV Audio Merger
**BatchMerge** is a Windows application that allows you to merge audio tracks from one batch of MKV files into another. It supports folder-level batch processing and gives you control over which track to copy, and whether it should be set as default or forced.

# Features

+ Merge audio tracks from one MKV file (source) into another MKV file (target)
+ Batch processing: automatically merge all files in selected folders
+ Select which audio track to copy over using Track ID
+ Optionally set the copied track as default or forced
+ Inspect detailed MKV file metadata using built-in JSON output from mkvmerge

# How to Use

1. Click Open folder under "Files to merge audio track FROM" and select the folder containing the MKV files whose audio tracks you want to copy.
2. Click Open folder under "Files to merge audio track INTO" and select the folder containing the target MKV files.
3. The lists display the files in both folders. You can see detailed JSON metadata below each list.
4. Use the numeric selector to choose which track ID from the source files you want to copy.
5. Click Start merge. Progress bars will update.

# Notes

+ Ensure that the source and destination folders have the **same number of files** in the same order to match episodes correctly.
+ Metadata is shown in JSON format for each selected file to help verify tracks, languages, and other properties before merging.
+ The program uses **mkvmerge** for merging. Make sure it is correctly installed and accessible.
+ mkvmerge is distributed as part of MKVToolNix. Grab the portable version from here: https://mkvtoolnix.download/downloads.html#windows and use the mkvmerge.exe from that archive.

# Requirements

+ Windows 10 or higher
+ .NET 8.0 or higher
+ The mkvmerge.exe must be placed in the **same folder** as BatchMerge or accessible in your system PATH

# Screenshot
<img alt="image" src="https://github.com/user-attachments/assets/e2d471bd-cafb-473e-8745-189454736bd8" />
