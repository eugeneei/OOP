using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;

namespace WindowsFormsApp1
{
    public class Plagins
    {
        public List<Figure> plugins = new List<Figure>();

        public Plagins()
        {
            RefreshPlugins();
        }

        public string PluginPath { get; } = Path.Combine(Directory.GetCurrentDirectory(), "Plugins");

        private void RefreshPlugins()
        {
            plugins.Clear();

            DirectoryInfo pluginDirectory = new DirectoryInfo(PluginPath);
            if (!pluginDirectory.Exists)
                pluginDirectory.Create();

            var pluginFiles = Directory.GetFiles(PluginPath, "*.dll");
            foreach (var file in pluginFiles)
            {
                Assembly asm = Assembly.LoadFrom(file);

                 var types = asm.GetTypes().Where(t => t.GetInterfaces().
                 Where(i => i.FullName == typeof(Figure).FullName).Any());

                foreach (var type in types)
                {
                    var plugin = asm.CreateInstance(type.FullName) as Figure;
                    plugins.Add(plugin);
                }
            }
        }
    }
}