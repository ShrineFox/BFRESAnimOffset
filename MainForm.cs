﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ShrineFox.IO;

namespace BFRESAnimOffset
{
    public partial class MainForm : Form
    {
        public static string filePath;
        public static List<string> fileLines;
        public static List<Bone> bones;

        public MainForm()
        {
            InitializeComponent();
            bones = new List<Bone>();
        }

        private void OpenFile_Click(object sender, EventArgs e)
        {
            filePath = ShrineFox.IO.WinFormsEvents.FilePath_Click("Choose .anim file...", false, new string[] { "Animation (.anim)" }).First();
            OpenFile();
            PopulateList();
        }

        private void PopulateList()
        {
            listBox_Bones.Items.Clear();

            foreach(var bone in bones)
            {
                if (!listBox_Bones.Items.Contains(bone.Name))
                    listBox_Bones.Items.Add(bone.Name);
            }
        }

        private void OpenFile()
        {
            fileLines = File.ReadAllLines(filePath).ToList();
            
            for (int i = 0; i < fileLines.Count(); i++)
            {
                if (fileLines[i].StartsWith("anim "))
                {
                    Bone bone = new Bone();

                    string[] splitLine = fileLines[i].Split(' ');
                    bone.Name = splitLine.Reverse().ToArray()[3];

                    if (bones.Any(x => x.Name.Equals(bone.Name)))
                    {
                        bone = bones.Single(x => x.Name.Equals(bone.Name));
                        bones.Remove(bone);
                    }
                    
                    string type = splitLine.Reverse().ToArray()[4];
                    List<Key> keyData = GetKeyData(i);
                    switch (type)
                    {
                        case "translateX":
                            bone.TranslateX = keyData;
                            break;
                        case "translateY":
                            bone.TranslateY = keyData;
                            break;
                        case "translateZ":
                            bone.TranslateZ = keyData;
                            break;
                        case "rotateX":
                            bone.RotateX = keyData;
                            break;
                        case "rotateY":
                            bone.RotateY = keyData;
                            break;
                        case "rotateZ":
                            bone.RotateZ = keyData;
                            break;
                        case "scaleX":
                            bone.ScaleX = keyData;
                            break;
                        case "scaleY":
                            bone.ScaleY = keyData;
                            break;
                        case "scaleZ":
                            bone.ScaleZ = keyData;
                            break;
                        default:
                            break;
                    }

                    bones.Add(bone);
                }
            }
        }

        private List<Key> GetKeyData(int lineNumber)
        {
            List<Key> keyData = new List<Key>();
            for (int i = lineNumber; i < fileLines.Count(); i++)
            {
                if (fileLines[i].StartsWith(" ") && !fileLines[i].StartsWith("  ") && !fileLines[i].StartsWith(" }"))
                {
                    Key key = new Key();
                    string[] splitLines = fileLines[i].Split(' ').ToArray();
                    key.ID = Convert.ToInt32(splitLines[1]);
                    key.Value = Convert.ToSingle(splitLines[2]);
                    key.Data = fileLines[i].Substring(fileLines[i].IndexOf(splitLines[2]) + splitLines[2].Length).Replace(";", "").Trim();
                    keyData.Add(key);

                    // TODO: Actually remove line?
                    // Remove line
                    fileLines.RemoveAt(i);
                }

                if (fileLines[i].Trim() == "}")
                    break;
            }
            return keyData;
        }

        private void SelectedBone_Changed(object sender, EventArgs e)
        {
            Bone bone = bones.Single(x => x.Name.Equals(listBox_Bones.SelectedItem.ToString()));
            ResetOffsetValues();
            ResetEnabledFields();
            UpdateKeyDataPrintout(bone);
        }

        private void ResetEnabledFields()
        {
            Bone bone = bones.Single(x => x.Name.Equals(listBox_Bones.SelectedItem.ToString()));
            num_TranslateX.Enabled = (bone.TranslateX.Count > 0); 
            num_RotateX.Enabled = (bone.RotateX.Count > 0); 
            num_ScaleX.Enabled = (bone.ScaleX.Count > 0);
            num_TranslateY.Enabled = (bone.TranslateY.Count > 0); 
            num_RotateY.Enabled = (bone.RotateY.Count > 0); 
            num_ScaleY.Enabled = (bone.ScaleY.Count > 0);
            num_TranslateZ.Enabled = (bone.TranslateZ.Count > 0); 
            num_RotateZ.Enabled = (bone.RotateZ.Count > 0); 
            num_ScaleZ.Enabled = (bone.ScaleZ.Count > 0);
        }

        private void ResetOffsetValues()
        {
            num_TranslateX.Value = 0; num_RotateX.Value = 0; num_ScaleX.Value = 0;
            num_TranslateY.Value = 0; num_RotateY.Value = 0; num_ScaleY.Value = 0;
            num_TranslateZ.Value = 0; num_RotateZ.Value = 0; num_ScaleZ.Value = 0;
        }

        private void UpdateKeyDataPrintout(Bone bone)
        {
            rtb_KeyframeData.Clear();
            PrintKeyData(bone.TranslateX, bone.Name + " X Translation:");
            PrintKeyData(bone.TranslateY, bone.Name + " Y Translation:");
            PrintKeyData(bone.TranslateZ, bone.Name + " Z Translation:");
            PrintKeyData(bone.RotateX, bone.Name + " X Rotation:");
            PrintKeyData(bone.RotateY, bone.Name + " Y Rotation:");
            PrintKeyData(bone.RotateZ, bone.Name + " Z Rotation:");
            PrintKeyData(bone.ScaleX, bone.Name + " X Scale:");
            PrintKeyData(bone.ScaleY, bone.Name + " Y Scale:");
            PrintKeyData(bone.ScaleZ, bone.Name + " Z Scale:");
        }

        private void PrintKeyData(List<Key> keys, string header)
        {
            if (keys.Count != 0)
            {
                rtb_KeyframeData.Text += header;
                foreach (var key in keys)
                {
                    rtb_KeyframeData.Text += $"\n {key.ID} {key.Value} {key.Data}";
                }
                rtb_KeyframeData.Text += $"\n";
            }
        }

        private void XTranslation_Click(object sender, EventArgs e)
        {
            Bone bone = bones.Single(x => x.Name.Equals(listBox_Bones.SelectedItem.ToString()));
            rtb_KeyframeData.Clear();
            PrintKeyData(bone.TranslateX, bone.Name + " X Translation:");
        }

        private void YTranslation_Click(object sender, EventArgs e)
        {
            Bone bone = bones.Single(x => x.Name.Equals(listBox_Bones.SelectedItem.ToString()));
            rtb_KeyframeData.Clear();
            PrintKeyData(bone.TranslateY, bone.Name + " Y Translation:");
        }

        private void ZTranslation_Click(object sender, EventArgs e)
        {
            Bone bone = bones.Single(x => x.Name.Equals(listBox_Bones.SelectedItem.ToString()));
            rtb_KeyframeData.Clear();
            PrintKeyData(bone.TranslateZ, bone.Name + " Z Translation:");
        }

        private void XRotation_Click(object sender, EventArgs e)
        {
            Bone bone = bones.Single(x => x.Name.Equals(listBox_Bones.SelectedItem.ToString()));
            rtb_KeyframeData.Clear();
            PrintKeyData(bone.RotateX, bone.Name + " X Rotation:");
        }

        private void YRotation_Click(object sender, EventArgs e)
        {
            Bone bone = bones.Single(x => x.Name.Equals(listBox_Bones.SelectedItem.ToString()));
            rtb_KeyframeData.Clear();
            PrintKeyData(bone.RotateY, bone.Name + " Y Rotation:");
        }

        private void ZRotation_Click(object sender, EventArgs e)
        {
            Bone bone = bones.Single(x => x.Name.Equals(listBox_Bones.SelectedItem.ToString()));
            rtb_KeyframeData.Clear();
            PrintKeyData(bone.RotateZ, bone.Name + " Z Rotation:");
        }

        private void XScale_Click(object sender, EventArgs e)
        {
            Bone bone = bones.Single(x => x.Name.Equals(listBox_Bones.SelectedItem.ToString()));
            rtb_KeyframeData.Clear();
            PrintKeyData(bone.ScaleX, bone.Name + " X Scale:");
        }

        private void YScale_Click(object sender, EventArgs e)
        {
            Bone bone = bones.Single(x => x.Name.Equals(listBox_Bones.SelectedItem.ToString()));
            rtb_KeyframeData.Clear();
            PrintKeyData(bone.ScaleY, bone.Name + " Y Scale:");
        }

        private void ZScale_Click(object sender, EventArgs e)
        {
            Bone bone = bones.Single(x => x.Name.Equals(listBox_Bones.SelectedItem.ToString()));
            rtb_KeyframeData.Clear();
            PrintKeyData(bone.ScaleZ, bone.Name + " Z Scale:");
        }

        private void Apply_Click(object sender, EventArgs e)
        {
            Bone bone = bones.Single(x => x.Name.Equals(listBox_Bones.SelectedItem.ToString()));

            // TODO: Match rounding?
            bone.TranslateX = UpdateKeyValues(bone.TranslateX, num_TranslateX.Value);
            bone.TranslateY = UpdateKeyValues(bone.TranslateY, num_TranslateY.Value);
            bone.TranslateZ = UpdateKeyValues(bone.TranslateZ, num_TranslateZ.Value);
            bone.RotateX = UpdateKeyValues(bone.RotateX, num_RotateX.Value);
            bone.RotateY = UpdateKeyValues(bone.RotateY, num_RotateY.Value);
            bone.RotateZ = UpdateKeyValues(bone.RotateZ, num_RotateZ.Value);
            bone.ScaleX = UpdateKeyValues(bone.ScaleX, num_ScaleX.Value);
            bone.ScaleY = UpdateKeyValues(bone.ScaleY, num_ScaleY.Value);
            bone.ScaleZ = UpdateKeyValues(bone.ScaleZ, num_ScaleZ.Value);

            UpdateKeyDataPrintout(bone);
            ResetOffsetValues();
        }

        private List<Key> UpdateKeyValues(List<Key> keys, decimal value)
        {
            float offset = Convert.ToSingle(value);
            foreach (var key in keys)
            {
                // TODO: Match signage when adding value
                //if ((key.Value < 0 && offset >= 0) || (key.Value >= 0 && offset > 0))
                    //key.Value *= -1;
                
                key.Value += offset;
            }
            return keys;
        }

        private void SaveFile_Click(object sender, EventArgs e)
        {
            filePath = ShrineFox.IO.WinFormsEvents.FilePath_Click("Save .anim file...", false, new string[] { "Animation (.anim)" }).First();

            List<string> newLines = new List<string>();

            string name = "";
            string type = "";
            for (int i = 0; i < fileLines.Count(); i++)
            {
                newLines.Add(fileLines[i]);
                if (fileLines[i].StartsWith("anim "))
                {
                    string[] splitLine = fileLines[i].Split(' ');
                    name = splitLine.Reverse().ToArray()[3];
                    type = splitLine.Reverse().ToArray()[4];
                }
                if (fileLines[i].StartsWith("  keys {"))
                {
                    List<Key> keys = new List<Key>();
                    Bone bone = bones.Single(x => x.Name.Equals(name.ToString()));
                    switch (type)
                    {
                        case "translateX":
                            keys = bone.TranslateX;
                            break;
                        case "translateY":
                            keys = bone.TranslateY;
                            break;
                        case "translateZ":
                            keys = bone.TranslateZ;
                            break;
                        case "rotateX":
                            keys = bone.RotateX;
                            break;
                        case "rotateY":
                            keys = bone.RotateY;
                            break;
                        case "rotateZ":
                            keys = bone.RotateZ;
                            break;
                        case "scaleX":
                            keys = bone.ScaleX;
                            break;
                        case "scaleY":
                            keys = bone.ScaleY;
                            break;
                        case "scaleZ":
                            keys = bone.ScaleZ;
                            break;
                        default:
                            break;
                    }
                    // Add key data to list
                    foreach (var key in keys)
                        newLines.Add($" {key.ID} {key.Value} {key.Data}");
                }
            }

            File.WriteAllLines(filePath, newLines);
            ShrineFox.IO.WinFormsDialogs.OKMsgBox("Save Successful", $"Successfully saved data to new file:\n\n{filePath}");
        }
    }

    public class Bone
    {
        public string Name { get; set; } = "";
        public List<Key> TranslateX { get; set; } = new List<Key>();
        public List<Key> TranslateY { get; set; } = new List<Key>();
        public List<Key> TranslateZ { get; set; } = new List<Key>();
        public List<Key> RotateX { get; set; } = new List<Key>();
        public List<Key> RotateY { get; set; } = new List<Key>();
        public List<Key> RotateZ { get; set; } = new List<Key>();
        public List<Key> ScaleX { get; set; } = new List<Key>();
        public List<Key> ScaleY { get; set; } = new List<Key>();
        public List<Key> ScaleZ { get; set; } = new List<Key>();
    }

    public class Key
    {
        public int ID { get; set; } = 0;
        public float Value { get; set; } = 0f;
        public string Data { get; set; } = "";
    }
}