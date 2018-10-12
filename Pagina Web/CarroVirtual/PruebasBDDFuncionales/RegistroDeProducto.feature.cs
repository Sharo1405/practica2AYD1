We could not find a data exchange file at the path TechTalk.SpecFlow.SpecFlowException: Unable to find plugin in the plugin search path: SpecRun. Please check http://go.specflow.org/doc-plugins for details.

Please open an issue at https://github.com/techtalk/SpecFlow/issues/
Complete output: 
TechTalk.SpecFlow.SpecFlowException: Unable to find plugin in the plugin search path: SpecRun. Please check http://go.specflow.org/doc-plugins for details.
   en TechTalk.SpecFlow.Generator.Plugins.GeneratorPluginLoader.LoadPlugin(PluginDescriptor pluginDescriptor)
   en TechTalk.SpecFlow.Generator.GeneratorContainerBuilder.<>c__DisplayClass3.<LoadPlugins>b__1(PluginDescriptor pd)
   en System.Linq.Enumerable.WhereSelectEnumerableIterator`2.MoveNext()
   en System.Linq.Enumerable.<ConcatIterator>d__59`1.MoveNext()
   en System.Linq.Buffer`1..ctor(IEnumerable`1 source)
   en System.Linq.Enumerable.ToArray[TSource](IEnumerable`1 source)
   en TechTalk.SpecFlow.Generator.GeneratorContainerBuilder.LoadPlugins(ObjectContainer container, IGeneratorConfigurationProvider configurationProvider, SpecFlowConfigurationHolder configurationHolder)
   en TechTalk.SpecFlow.Generator.GeneratorContainerBuilder.CreateContainer(SpecFlowConfigurationHolder configurationHolder, ProjectSettings projectSettings)
   en TechTalk.SpecFlow.Generator.TestGeneratorFactory.CreateGenerator(ProjectSettings projectSettings)
   en TechTalk.SpecFlow.VisualStudio.CodeBehindGenerator.Actions.GenerateTestFileAction.GenerateTestFile(GenerateTestFileParameters opts)



Command: C:\Users\Koka\AppData\Local\Microsoft\VisualStudio\15.0_167c9211\Extensions\lpa5v32i.ykk\TechTalk.SpecFlow.VisualStudio.CodeBehindGenerator.exe
Parameters: GenerateTestFile --featurefile C:\Users\Koka\AppData\Local\Temp\tmp5B56.tmp --outputdirectory C:\Users\Koka\AppData\Local\Temp --projectsettingsfile C:\Users\Koka\AppData\Local\Temp\tmp5B55.tmp
Working Directory: C:\Users\Koka\Documents\Ingenieria\AYD1\Lab\Practica 3\practica2AYD1\Pagina Web\CarroVirtual\packages\SpecFlow.2.4.0\tools