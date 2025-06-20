using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ColorPicker : MonoBehaviour
{
    public Color[] AvailableColors;
    public Button ColorButtonPrefab;

    public Color SelectedColor { get; private set; }
    public System.Action<Color> onColorChanged;

    List<Button> m_ColorButtons = new List<Button>();

    // Start is called before the first frame update
    public void Init()
    {

        foreach (var color in AvailableColors)
        {
            var newButton = Instantiate(ColorButtonPrefab, transform);
            newButton.GetComponent<Image>().color = color;

            // Retrieve the color from PlayerPrefs.
            Color savedColor = GetSavedColor();


            // If it match with a button color, then add a little mark in it.
            if (color == savedColor)
            {
                newButton.interactable = false;
            }

            newButton.onClick.AddListener(() =>
            {
                SelectedColor = color;

                SaveColor(SelectedColor);

                foreach (var button in m_ColorButtons)
                {
                    button.interactable = true;
                }

                newButton.interactable = false;

            });

            m_ColorButtons.Add(newButton);
        }
    }

    public void SelectColor(Color color)
    {
        for (int i = 0; i < AvailableColors.Length; ++i)
        {
            if (AvailableColors[i] == color)
            {
                m_ColorButtons[i].onClick.Invoke();
            }
        }
    }

    private Color GetSavedColor()
    {
        float r = PlayerPrefs.GetFloat("ColorR");
        float g = PlayerPrefs.GetFloat("ColorG");
        float b = PlayerPrefs.GetFloat("ColorB");
        float a = PlayerPrefs.GetFloat("ColorA");

        return new Color(r, g, b, a);
    }

    private void SaveColor(Color color)
    {
        PlayerPrefs.SetFloat("ColorR", color.r);
        PlayerPrefs.SetFloat("ColorG", color.g);
        PlayerPrefs.SetFloat("ColorB", color.b);
        PlayerPrefs.SetFloat("ColorA", color.a);
    }
}
